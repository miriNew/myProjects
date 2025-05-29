using BlApi;
using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public List<SaleInProduct> AddProductToOrder(Order order, int productId, int quantity)
        {
            BO.Product product = BO.Tools.convertProductDoToBo(_dal.Product.Read(productId));
            //הוספה
            if (order.ProductInOrder == null)
            {
                order.ProductInOrder = new List<BO.ProductInOrder>();
            }
            //
            BO.ProductInOrder prodductsInOrder = order.ProductInOrder.FirstOrDefault(p => p.Id == product.Id);
            if (prodductsInOrder != null)
            {
                if (product.QuantityInStock >= quantity)
                {
                    prodductsInOrder.Amount += quantity;
                    product.QuantityInStock -= quantity;
                    Console.WriteLine($"{quantity} products added to your order");
                }
                else
                {
                    int q = product.QuantityInStock;
                    prodductsInOrder.Amount += q;
                    product.QuantityInStock = 0;
                    Console.WriteLine($"{product.QuantityInStock} products added to your order");
                    throw new Exception();
                }
            }
            else
            {
                if (product.QuantityInStock >= quantity)
                {
                    BO.ProductInOrder p = new BO.ProductInOrder
                    {
                        Id = product.Id,
                        ProductName = product.ProductName,
                        BasePrice = product.Price,
                        Amount = quantity
                    };
                    SearchSaleForProduct(p, order.PreferedCustomer);
                    CalcTotalPriceForProduct(p);
                    //לזכור לזמן את הפונקציות המתאימות לחישוב המחיר הסופי ולרשימת מבצעים
                    order.ProductInOrder.Add(p);
                    Console.WriteLine($"{quantity} products added to your order");
                    product.QuantityInStock -= quantity;
                    //צריך לעשות כאן עידכון מוצר?
                }
                else
                {
                    if (product.QuantityInStock > 0)
                    {
                        BO.ProductInOrder p = new BO.ProductInOrder
                        {
                            Id = product.Id,
                            ProductName = product.ProductName,
                            BasePrice = product.Price,
                            Amount = product.QuantityInStock,
                            FinalPrice = 0
                        };
                        SearchSaleForProduct(p, order.PreferedCustomer);
                        CalcTotalPriceForProduct(p);
                        //לזכור לזמן את הפונקציות המתאימות לחישוב המחיר הסופי ולרשימת מבצעים
                        order.ProductInOrder.Add(p);
                        Console.WriteLine($"{product.QuantityInStock} products added to your order");
                        product.QuantityInStock = 0;
                        //צריך לעשות כאן עידכון מוצר?

                    }
                    else
                        Console.WriteLine("There are no units of this product in stock.");
                    //throw new Exception();
                }
            }
            return prodductsInOrder?.SaleList ?? new List<BO.SaleInProduct>();
        
    }

        public void CalcTotalPrice(Order order)
        {
            try
            {
                order.Price = order.ProductInOrder.Select(p => p.FinalPrice).Sum();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public void CalcTotalPriceForProduct(ProductInOrder product)
        {
        try
        {
                BO.Product p = BO.Tools.convertProductDoToBo(_dal.Product.Read(product.Id));
            if (product.SaleList == null)
            {
                product.FinalPrice = p.Price * product.Amount;
            }
            else
            {
                int count = product.Amount;
                foreach (BO.SaleInProduct sale in product.SaleList)
                {
                    if (sale.Amount > count)
                        continue;
                    else
                    {
                        int c = count / sale.Amount;
                        product.SaleList.Add(sale);
                        product.FinalPrice += c * sale.Price;
                        count -= c * sale.Amount;
                        if (count == 0)
                            break;
                    }
                }
                product.FinalPrice += count * p.Price;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }


        public void DoOrder(Order order)
        {
        try
        {
            foreach (BO.ProductInOrder p in order.ProductInOrder)
            {
                BO.Product prod = BO.Tools.convertProductDoToBo(_dal.Product.Read(p.Id));
                prod.QuantityInStock -= p.Amount;
                _dal.Product.Update(BO.Tools.convertProductBoToDo(prod));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

        public void SearchSaleForProduct(ProductInOrder product, bool existCustomer)
        {
            try
            {
                product.SaleList = _dal.Sale.ReadAll()
                                    .Where(sale => sale.ProductId == product.Id &&
                                           sale.BeginSale <= DateTime.Now &&
                                           sale.EndSale >= DateTime.Now &&
                                           sale.MinQuantity <= product.Amount &&
                                           (!(sale.InClab) || existCustomer)).Select(s => BO.Tools.convertSaleBoToSaleInProductBo(s)).ToList();
                product.SaleList = product.SaleList.OrderBy(s => s.Price / s.Amount).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
    


