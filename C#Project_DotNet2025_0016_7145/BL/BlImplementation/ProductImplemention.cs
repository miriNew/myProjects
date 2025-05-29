
using BlApi;


namespace BlImplementation;

internal class ProductImplemention : IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Product item)
    {
        try
        {
            DO.Product p = BO.Tools.convertProductBoToDo(item);
            return _dal.Product.Create(p);
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Product.Delete(id);
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public List<BO.SaleInProduct> IfSaleIsValidity(int id, bool PreferedCustomer)
    {
        return _dal.Sale.ReadAll().Where(c => c.BeginSale <= DateTime.Now &&
                                         c.EndSale >= DateTime.Now &&
                                         (!c.InClab || PreferedCustomer))
                                         .Select(s=> BO.Tools.convertSaleBoToSaleInProductBo(s)).ToList();
    }

    public BO.Product? Read(int id)
    {
        try
        {
            BO.Product p = BO.Tools.convertProductDoToBo(_dal.Product.Read(id));
            return p;
        }catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        



    }

    public List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        try
        {
            Func<DO.Product, bool>? filterDO = null;
            if (filter != null)
            {
                filterDO = c => filter(BO.Tools.convertProductDoToBo(c));
            }


            var data = _dal.Product.ReadAll(filterDO);

            var customers = data.Select(c => BO.Tools.convertProductDoToBo(c)).ToList();

            return customers;
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Update(BO.Product item)
    {
        try
        {
            DO.Product p2 = BO.Tools.convertProductBoToDo(item);
            _dal.Product.Update(p2);
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
