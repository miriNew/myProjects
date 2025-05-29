
 namespace Dal;
using DO;
using DalApi;
using Tools;
using System.Reflection;

internal class ImplementationProduct : IProduct
{
    public int Create(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Product p = item with { Id = DataSource.Config.productCode };
        DataSource.Products.Add(p);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"the product: {item.ProductName} added successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return p.Id;    
    }

    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Product p = Read(id);
        DataSource.Products.Remove(p);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"the product: {p.ProductName} deleted successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }

    public Product? Read(int id)
    {
        //foreach (Product p in DataSource.Products) {
        //     if (p.Id == id) { return p; }
        // }
        //throw new Dal_CodeNotFound("code not found");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var P = DataSource.Products.FirstOrDefault(p => p.Id == id);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return P ??   throw new Dal_CodeNotFound("code not found");
        
    }

    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var res = DataSource.Products.FirstOrDefault(c => filter(c));
        if (res != null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return res;
        }
        else throw new Dal_objectNotFound("the product not found");
    }

    

    public List<Product> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var data = from p in DataSource.Products
                 where filter == null||filter(p)
                 select p;
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return data.ToList();
    }

    public void Update(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Delete(item.Id);
        DataSource.Products.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"the product: {item.ProductName} updated successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }
}

