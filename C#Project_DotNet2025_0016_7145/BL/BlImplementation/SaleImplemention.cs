
using BlApi;


namespace BlImplementation;

internal class SaleImplemention : ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(  BO.Sale item)
    {
        try
        {
            DO.Sale s = BO.Tools.converSaletBoToDo(item);
            return _dal.Sale.Create(s);
        }catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Sale.Delete(id);
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public BO.Sale? Read(int id)
    {
        try
        {
            BO.Sale p = BO.Tools.convertSaleDoToBo(_dal.Sale.Read(id));
            return p;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<BO.Sale> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        Func<DO.Sale, bool>? filterDO = null;
        if (filter != null)
        {
            filterDO = c => filter(BO.Tools.convertSaleDoToBo(c));
        }


        var data = _dal.Sale.ReadAll(filterDO);

        var customers = data.Select(c => BO.Tools.convertSaleDoToBo(c)).ToList();

        return customers;
    }

    public void Update(BO.Sale item)
    {
        DO.Sale s2 = BO.Tools.converSaletBoToDo(item);
        _dal.Sale.Update(s2);  
    }
}
