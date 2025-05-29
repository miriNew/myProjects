using BlApi;
using BO;
using System.Reflection;
using System.Xml.Serialization;
using Tools;


namespace BlImplementation;

internal class ProductImplementation : IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Product item)
    {
        try
        {
            DO.Product prod = BO.Tools.convertProductBoToDo(item);
            return _dal.Product.Create(prod);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Product.Delete(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public List<SaleInProduct> IfSaleIsValidity(int id, bool PreferedCustomer)
    {
        return _dal.Sale.ReadAll().Where(sale => sale.ProductId == id &&
                                          sale.BeginSale <= DateTime.Now &&
                                          sale.EndSale >= DateTime.Now &&
                                          (!(sale.InClab) || PreferedCustomer))
                                          .Select(s => BO.Tools.convertSaleBoToSaleInProductBo(s)).ToList();
    }

    public BO.Product? Read(int id)
    {
        try
        {
            return BO.Tools.convertProductDoToBo(_dal.Product.Read(id));
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        try
        {
            return _dal.Product.ReadAll(prod => filter(BO.Tools.convertProductDoToBo(prod)))
                .Select(c => BO.Tools.convertProductDoToBo(c)).ToList();
        }
        catch (DO.Dal_objectNotFound e)
        {
            throw new BO.BL_objectNotFound(e.Message, e);
        }
    }

    public void Update(BO.Product item)
    {
        try
        {
            DO.Product prod = BO.Tools.convertProductBoToDo(item);
            _dal.Product.Update(prod);
        }
        catch (DO.Dal_CodeNotFound e)
        {
            throw new BO.BL_CodeNotFound("", e);
        }
    }
}
