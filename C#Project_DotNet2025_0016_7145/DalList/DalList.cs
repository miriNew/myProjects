

using DalApi;

namespace Dal;

internal sealed class DalList : IDal
{
    public ISale Sale => new ImplementationSale();
    public IProduct Product => new ImplementationProduct(); 
    public ICustomer Customer => new ImplementationCustomer();

    public static readonly DalList Instance = new DalList();
    private DalList() { }
}
