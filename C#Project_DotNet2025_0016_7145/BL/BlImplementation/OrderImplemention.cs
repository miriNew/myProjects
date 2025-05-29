
using BlApi;

namespace BlImplementation;

internal class OrderImplemention : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int quantity)
    {
        // שליפת המוצר מה-DAL
        BO.Product product = BO.Tools.convertProductDoToBo(_dal.Product.Read(productId));

        if (product == null)
            throw new Exception("המוצר לא נמצא במערכת");

        BO.ProductInOrder existingProduct = order.ProductInOrder.FirstOrDefault(p => p.Id == productId);

        if (existingProduct != null)
        {
            // בדיקה אם הכמות החדשה חוקית
            if (existingProduct.Amount + quantity < 0)
                throw new Exception("לא ניתן להפחית כמות מעבר לכמות הקיימת בהזמנה");

            if (existingProduct.Amount + quantity > product.QuantityInStock)
                throw new Exception("אין מספיק מלאי במערכת");

            // עדכון הכמות בהזמנה
            existingProduct.Amount += quantity;
        }
        else
        {
            // אם המוצר לא קיים בהזמנה
            if (quantity > product.QuantityInStock)
                throw new Exception("אין מספיק מלאי במערכת");

            // הוספת המוצר להזמנה
            existingProduct = new BO.ProductInOrder
            {
                Id = productId,
                Amount = quantity,
                BasePrice = product.Price,
                FinalPrice = 0,
                SaleList = new List<BO.SaleInProduct>()
            };
            order.ProductInOrder.Add(existingProduct);
        }

        // חיפוש מבצעים רלוונטיים למוצר
        SearchSaleForProduct(existingProduct,order.PreferedCustomer);

        // חישוב מחיר המוצר בהזמנה
        CalcTotalPriceForProduct(existingProduct);

        // חישוב מחיר ההזמנה הכולל
        CalcTotalPrice(order);

        return existingProduct.SaleList;
    }


    public void CalcTotalPrice(BO.Order order)
    {
        try
        {
            foreach (BO.ProductInOrder p in order.ProductInOrder)
            {
                order.Price += p.FinalPrice;
            }
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void CalcTotalPriceForProduct(BO.ProductInOrder product)
    {
        try
        {
            BO.Product p = BO.Tools.convertProductDoToBo(_dal.Product.Read(product.Id));

            if (product.SaleList == null)
            {
                p.Price = p.Price * product.Amount;
            }
            else
            {
                int count = product.Amount;
                foreach (BO.SaleInProduct s in product.SaleList)
                {
                    if (count < s.Amount)
                        continue;
                    if (count > s.Amount)
                    {
                        product.SaleList.Add(s);
                        product.FinalPrice += (count / s.Amount) * p.Price;
                        count -= (count / s.Amount) * s.Amount;
                        if (count == 0)
                            break;
                    }

                }
                product.FinalPrice = count * p.Price;

            }
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void DoOrder(BO.Order order)
    {
        try
        {
            foreach (BO.ProductInOrder p in order.ProductInOrder)
            {
                BO.Product pr = BO.Tools.convertProductDoToBo(_dal.Product.Read(p.Id));
                pr.QuantityInStock -= p.Amount;
                _dal.Product.Update(BO.Tools.convertProductBoToDo(pr));
            }
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }




    }

    public void SearchSaleForProduct(BO.ProductInOrder order, bool existCustomer)
    {
        try {
            order.SaleList = _dal.Sale.ReadAll().Where(c => c.ProductId == order.Id &&
                                                       DateTime.Now >= c.BeginSale &&
                                                       DateTime.Now <= c.EndSale &&
                                                       order.Amount >= c.MinQuantity &&
                                                       (!c.InClab || existCustomer))
                                                       .Select(s => BO.Tools.convertSaleBoToSaleInProductBo(s)).ToList();

            order.SaleList = order.SaleList.OrderBy(k => k.Price/k.Amount).ToList();
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
