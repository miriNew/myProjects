using DalApi;
using DalTest;
using DO;
using System.Reflection;


internal class Program
{
    //private static ICustomer? _dalCustomer = new CustomerImplementation();
    //private static Isale? _dalSale = new ImplementationSale();
    //private static Iproduct? _dalProduct = new ImplementationProduct();
    private static readonly IDal s_dal = DalApi.Factory.Get;
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        initialization.initialize();
        try
        {
            int select1;
            select1 = PrintMenu();
            int select2;
            while (select1 != 0) {
                switch (select1)
                {
                    case 1:
                        Console.WriteLine("product");
                        //select2 = PrintSubMenu("מוצרים");
                        ProductMenu();
                        break;
                    case 2:
                        Console.WriteLine("customer");
                        //select2 = PrintSubMenu("לקוחות");
                        CustomerMenu();
                        break;
                    case 3:
                        Console.WriteLine("sale");
                        //select2 = PrintSubMenu("מבצעים");
                        SaleMenu();
                        break;
                    default: Console.WriteLine(" error!! please press again");
                        break;

                }
                select1 = PrintMenu();
            }
        }catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
            ////LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);
        }
        
    }
    private static int PrintSubMenu(string item)
    {
        int select;
        Console.WriteLine($"add {item} press 1");
        Console.WriteLine($"get {item} press 2");
        Console.WriteLine($"getAll {item} press 3");
        Console.WriteLine($"delete {item} press 4");
        Console.WriteLine($"update {item} press 5");


        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;

    }






    public static int PrintMenu()
    {
        Console.WriteLine("products press 1");
        Console.WriteLine("customer press 2");
        Console.WriteLine("sales press 3");
        Console.WriteLine("exit press 0");

        int select;
        if (!int.TryParse(Console.ReadLine(), out select))

            select = -1;
        return select;


    }

    private static void ProductMenu()
    {
        int select;
        select = PrintSubMenu("products");
        while (select != 0)
        {
            switch (select)
            {
                case 1: AddProduct();
                    break;
                case 2: Read(s_dal.Product);
                    break;
                case 3: ReadAll(s_dal.Product.ReadAll());
                    break;
                case 4: Delete(s_dal.Product);
                    break;
                case 5: UpdateProduct();
                    break;
                default:
                    break;
            }
            select = PrintSubMenu("products");
        }
    }
    private static void AddProduct()
    {
        string productName;
        Categories category;
        double price;
        int QuantityInStock;
        Console.WriteLine("insert product name");
        productName = Console.ReadLine();
        Console.WriteLine("choose category between 0-3");
        int cat;
        if (!int.TryParse(Console.ReadLine(), out cat)) category = 0;
        else category = (Categories)cat;
        Console.WriteLine("insert price");
        if (!double.TryParse(Console.ReadLine(), out price)) price = 10;
        Console.WriteLine("insert quentity");
        if (!int.TryParse(Console.ReadLine(), out QuantityInStock)) QuantityInStock = 0;

        Product p = new Product(0, productName, category, price, QuantityInStock);
        int code = s_dal.Product.Create(p);
        p = p with { Id = code };

        Console.WriteLine("product created succesfully");
        Console.WriteLine(p);



    }
    private static void Read<T>(ICrud<T> ICrud)
    {
        try
        {
            Console.WriteLine("insert code");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(ICrud.Read(id));
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            ////LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);
        }

    }
    private static void ReadAll<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    private static void Delete<T>(ICrud<T> icrud)
    {
        try
        {
            Console.WriteLine("Enter Code");
            int code = int.Parse(Console.ReadLine());
            icrud.Delete(code);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            ////LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);
        }
    }
    private static void UpdateProduct()
    {
        string productName;
        Categories category;
        double price;
        int QuantityInStock;
        Console.WriteLine("insert product name");
        productName = Console.ReadLine();
        Console.WriteLine("choose category between 0-3");
        int cat;
        if (!int.TryParse(Console.ReadLine(), out cat)) category = 0;
        else category = (Categories)cat;
        Console.WriteLine("insert price");
        if (!double.TryParse(Console.ReadLine(), out price)) price = 10;
        Console.WriteLine("insert quentity");
        if (!int.TryParse(Console.ReadLine(), out QuantityInStock)) QuantityInStock = 0;

        Product p = new Product(0, productName, category, price, QuantityInStock);
        int code = s_dal.Product.Create(p);
        p = p with { Id = code };

        Console.WriteLine("prosuct update succesfully");
        Console.WriteLine(p);



    }
    private static void SaleMenu()
    {
        int select;
        select = PrintSubMenu("sale");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddSale();
                    break;
                case 2:
                    Read(s_dal.Sale);
                    break;
                case 3:
                    ReadAll(s_dal.Sale.ReadAll());
                    break;
                case 4:
                    Delete(s_dal.Sale);
                    break;
                case 5:
                    UpdateSale();
                    break;
                default:
                    break;
            }
            select = PrintSubMenu("sale");
        }
    }
    private static void AddSale()
    {
        int ProductId;
        int MinQuantity;
        double price;
        bool inClob;
        DateTime beginSale;
        DateTime endSale;
        Console.WriteLine("inaert sale code");
        ProductId = Console.Read();

        Console.WriteLine("insert price");
        if (!double.TryParse(Console.ReadLine(), out price)) price = 10;

        Console.WriteLine("insert min quntity in sale");
        if (!int.TryParse(Console.ReadLine(), out MinQuantity)) MinQuantity = 1;

        Console.WriteLine("in clab?");
        if (!bool.TryParse(Console.ReadLine(), out inClob)) inClob = false;

        Console.WriteLine("insert begin date");
        if (!DateTime.TryParse(Console.ReadLine(), out beginSale)) beginSale = DateTime.Now;

        Console.WriteLine("insert end date");
        if (!DateTime.TryParse(Console.ReadLine(), out endSale)) endSale = DateTime.Now.AddDays(1);

        Sale s = new Sale(0, ProductId, MinQuantity, price, inClob, beginSale, endSale);
        int code = s_dal.Sale.Create(s);
        s = s with { Code = code };

        Console.WriteLine("the sale creates succesfully");
        Console.WriteLine(s);



    }
    
   
    private static void UpdateSale()
    {
        int ProductId;
        int MinQuantity;
        double price;
        bool inClob;
        DateTime beginSale;
        DateTime endSale;
        Console.WriteLine("insert sale cose");
        ProductId = Console.Read();

        Console.WriteLine("insert price");
        if (!double.TryParse(Console.ReadLine(), out price)) price = 0;

        Console.WriteLine("insert min quantity in sale");
        if (!int.TryParse(Console.ReadLine(), out MinQuantity)) MinQuantity = 0;

        Console.WriteLine("in club?");
        if (!bool.TryParse(Console.ReadLine(), out inClob)) inClob = false;

        Console.WriteLine("insert begin date");
        if (!DateTime.TryParse(Console.ReadLine(), out beginSale)) beginSale = DateTime.Now;

        Console.WriteLine("insert end date");
        if (!DateTime.TryParse(Console.ReadLine(), out endSale)) endSale = DateTime.Now.AddDays(1);

        Sale s = new Sale(0, ProductId, MinQuantity, price, inClob, beginSale, endSale);
        int code = s_dal.Sale.Create(s);
        s = s with { Code = code };

        Console.WriteLine("the sale update succesfully");
        Console.WriteLine(s);



    }

    private static void CustomerMenu()
    {
        int select;
        select = PrintSubMenu("customer");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    Read(s_dal.Customer);
                    break;
                case 3:
                    ReadAll(s_dal.Customer.ReadAll());
                    break;
                case 4:
                    Delete(s_dal.Customer);
                    break;
                case 5:
                    UpdateCustomer();
                    break;
                default:
                    break;
            }
            select=PrintSubMenu("customer");
        }
    }


    private static void AddCustomer()
    {
        try
        {
            int id;
            string name;
            string address;
            int phone;

            Console.WriteLine("insert customer id");
            if (!int.TryParse(Console.ReadLine(), out id)) id = 0;

            Console.WriteLine("insert name");
            name = Console.ReadLine();

            Console.WriteLine("insert address");
            address = Console.ReadLine();

            Console.WriteLine("insert phone number");
            if (!int.TryParse(Console.ReadLine(), out phone)) phone = 0000000000;

            Customer c = new Customer(id, name, address, phone);
            int code = s_dal.Customer.Create(c);
            c = c with { Id = code };

            Console.WriteLine("the customer created succesfully");
            Console.WriteLine(c);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            ////LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);
        }


    }

   

        private static void UpdateCustomer()
    {

        int id;
        string name;
        string address;
        int phone;

        Console.WriteLine("insert customer id");
        id = Console.Read();

        Console.WriteLine("insert name");
        name = Console.ReadLine();

        Console.WriteLine("insert address");
        address = Console.ReadLine();

        Console.WriteLine("insert phone number");
        if (!int.TryParse(Console.ReadLine(), out phone)) phone = 0000000000;

        Customer c = new Customer(id, name, address, phone);
        int code = s_dal.Customer.Create(c);
        c = c with { Id = code };

        Console.WriteLine("the customer update succesfully");
        Console.WriteLine(c);



    }







}