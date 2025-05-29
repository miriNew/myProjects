
namespace Dal;
using DO;
using DalApi;
using Tools;
using System.Reflection;

internal class ImplementationCustomer : ICustomer
{
    public int Create(Customer item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var isExist = DataSource.Customers.FirstOrDefault(c => c.Id == item.Id);
            if (isExist != null)
            throw new Dal_IdIsExist("the customer is alredy");
            else DataSource.Customers.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"the customer: {item.Name} added successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return item.Id;
    }

    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Customer c = Read(id);
        DataSource.Customers.Remove(c); 
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"the customer: {c.Name} deleted successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }

    public Customer? Read(int id)
    {

        //foreach (Customer c in DataSource.Customers)
        //{
        //    if (c.Id == id) { return c; }
        //}
        //throw new Dal_CodeNotFound("code not found");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var C = DataSource.Customers.FirstOrDefault(c => c.Id == id);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return C ?? throw new Dal_CodeNotFound("code not found");
        
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var res = DataSource.Customers.FirstOrDefault(c => filter(c));
        if (res != null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return res;
        }
        else throw new Dal_objectNotFound("the customer not found");
    }

    

    public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var data = from c in DataSource.Customers
                   where filter == null || filter(c)    
                   select c;
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return data.ToList();
    }

    public void Update(Customer item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Delete(item.Id);
        DataSource.Customers.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"the customer: {item.Name} updated successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }
}

