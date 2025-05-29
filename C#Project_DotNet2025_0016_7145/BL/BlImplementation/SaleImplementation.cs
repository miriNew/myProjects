
using BlApi;
using DalApi;
using DO;
using System.Reflection;
using System.Xml.Linq;
using Tools;
using BlApi;
using BO;

namespace BlImplementation;
internal class SaleImplementation : BlApi.ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Sale item)
    {
        try
        {
            DO.Sale sale = BO.Tools.converSaletBoToDo(item);
            return _dal.Sale.Create(sale);
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
            _dal.Sale.Delete(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public BO.Sale? Read(int id)
    {
        try
        {
            return BO.Tools.convertSaleDoToBo(_dal.Sale.Read(id));
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public List<BO.Sale> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            return _dal.Sale.ReadAll(sale => filter(BO.Tools.convertSaleDoToBo(sale)))
                .Select(c => BO.Tools.convertSaleDoToBo(c)).ToList();
        }
        catch (DO.Dal_objectNotFound e)
        {
            throw new BO.BL_objectNotFound(e.Message, e);
        }
    }

    public void Update(BO.Sale item)
    {
        try
        {
            DO.Sale sale = BO.Tools.converSaletBoToDo(item);
            _dal.Sale.Update(sale);
        }
        catch (DO.Dal_CodeNotFound e)
        {
            throw new BO.BL_CodeNotFound("", e);
        }
    }
}
