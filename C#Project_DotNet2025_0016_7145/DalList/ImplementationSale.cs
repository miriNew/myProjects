namespace Dal;
using DO;
using DalApi;
using Tools;
using System.Reflection;

internal class ImplementationSale : ISale
{
    public int Create(Sale item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Sale s = item with { Code = DataSource.Config.SaleCode };
        DataSource.Sales.Add(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"sale for the product: {item.ProductId} added successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return s.Code;

    }

    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Sale s = Read(id);
        DataSource.Sales.Remove(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"sale for the product: {s.ProductId} deleted successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }

    public Sale? Read(int id)
    {
        //foreach (Sale s in DataSource.Sales)
        //{
        //    if (s.Code == id) { return s; }
        //}
        //throw new Dal_CodeNotFound("code not found");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var S = DataSource.Sales.FirstOrDefault(s => s.Code == id);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return S ??   throw new Dal_CodeNotFound("code not found");
       
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

        var res = DataSource.Sales.FirstOrDefault(c => filter(c));
        if (res != null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return res;
        }
        else throw new Dal_objectNotFound("the sale not found");
    }

    //public List<Sale> ReadAll()
    //{
    //    return new List<Sale?>(DataSource.Sales);
    //}

    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var data = from s in DataSource.Sales
                   where filter == null || filter(s)    
                   select s;
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return data.ToList();
    }

    public void Update(Sale item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Delete(item.Code);
        DataSource.Sales.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"sale for the product: {item.ProductId} updated successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }
}

