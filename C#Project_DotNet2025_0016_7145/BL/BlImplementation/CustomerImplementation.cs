using BlApi;
using BO;

namespace BlImplementation;

internal class CustomerImplementation : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Customer item)
    {
        try
        {
            DO.Customer cust = BO.Tools.convertCustomerBoToDo(item);
            return _dal.Customer.Create(cust);
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
            _dal.Customer.Delete(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public bool IsExist(int id)
    {
        try
        {
            DO.Customer cust = _dal.Customer.Read(id);
            if (cust != null)
                return true;
            return false;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public BO.Customer? Read(int id)
    {
        try
        {
            return BO.Tools.convertCustomerDoToBo(_dal.Customer.Read(id));
        }
        catch (Exception e)
        {
            throw new Exception (e.Message);
        }
    }

    public List<BO.Customer> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        try
        {
            return _dal.Customer.ReadAll(cust => filter(BO.Tools.convertCustomerDoToBo(cust)))
                .Select(c => BO.Tools.convertCustomerDoToBo(c)).ToList();
        }
        catch (DO.Dal_objectNotFound e)
        {
            throw new BO.BL_objectNotFound(e.Message, e);
        }
    }


    public void Update(BO.Customer item)
    {
        try
        {
            DO.Customer cust = BO.Tools.convertCustomerBoToDo(item);
            _dal.Customer.Update(cust);
        }
        catch (DO.Dal_CodeNotFound e)
        {
            throw new BO.BL_CodeNotFound("", e);
        }
    }

}