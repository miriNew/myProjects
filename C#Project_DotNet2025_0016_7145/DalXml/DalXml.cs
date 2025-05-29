using DalApi;

namespace Dal;

internal sealed class DalXml : IDal
{
    public ICustomer Customer => new CustomerImplementation();

    public IProduct Product => new ProductImplementation();

    public ISale Sale => new SaleImplementation();
    private DalXml() { }

    static readonly DalXml instance = new DalXml();
    public static DalXml Instance => instance;

}