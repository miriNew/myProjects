namespace DalTest;
using DO;
using DalApi;

public static class initialization
{
  // private static ICustomer? s_dalCustomer ;
  // private static Isale? s_dalSale;
   //private static Iproduct? s_dalProduct;
   private static List<int> productCodes = new List<int>();
   private static IDal s_dal;

    private static void createCustomer()
    {
        productCodes.Add(s_dal.Customer.Create(new Customer(100, "דסי", "שערי תשובה", 0504113652)));
        productCodes.Add(s_dal.Customer.Create(new Customer(101, "שירה", "רשבי", 0504113652)));
        productCodes.Add(s_dal.Customer.Create(new Customer(102, "מירי", "מתתיהו", 0504113652)));
        productCodes.Add(s_dal.Customer.Create(new Customer(103, "יעל", "שדי חמד", 0504113652)));

    }
    private static void createSale()
    {
        s_dal.Sale.Create(new Sale(0, productCodes[0],5,150,true,DateTime.Now,DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(0, productCodes[1], 3, 10, false, DateTime.Now, DateTime.Now.AddDays(5)));
        s_dal.Sale.Create(new Sale(0, productCodes[2], 2, 70, false, DateTime.Now, DateTime.Now.AddDays(1)));
        s_dal.Sale.Create(new Sale(0, productCodes[3], 4, 60, true, DateTime.Now, DateTime.Now.AddDays(8)));
    }
    private static void createProduct()
    {
        s_dal.Product.Create(new Product(0,"sofa",Categories.livingRoom,520,2));
        s_dal.Product.Create(new Product(0, "oven", Categories.kitchen, 5000, 2));
        s_dal.Product.Create(new Product(0, "light", Categories.livingRoom, 1200.5, 2));
        s_dal.Product.Create(new Product(0, "pair of bed", Categories.sleepDeprivation, 1630, 2));
    }

    public static void initialize()
    {
        s_dal = DalApi.Factory.Get;
        

        createCustomer();
        createSale();
        createProduct();
    }


}
