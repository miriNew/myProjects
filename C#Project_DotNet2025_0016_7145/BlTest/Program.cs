using BO;
using DalApi;
using DalTest;
using System;

namespace BlTest
{
    internal class Program
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

        static void Main(string[] args)
        {
            try
            {
                int select = -1;
                bool preferdCust = false;
                BO.Order order = new BO.Order();

                initialization.initialize();

                Console.WriteLine("Insert identify number:");
                if (int.TryParse(Console.ReadLine(), out int id) && id != 0)
                {
                    preferdCust = true;
                }

                while (select != 0)
                {
                    Console.WriteLine("Select an option: \n1. Add product \n2. Finish order \n0. Exit");
                    if (!int.TryParse(Console.ReadLine(), out select))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    switch (select)
                    {
                        case 1:
                            Console.WriteLine("Adding product...");
                            addProduct(order, preferdCust);
                            break;
                        case 2:
                            Console.WriteLine("Finishing order...");
                            finishOrder(preferdCust);
                            break;
                        case 0:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void addProduct(Order order, bool preferdCust)
        {
            try
            {
                Console.WriteLine("Insert product ID:");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    return;
                }

                Console.WriteLine("Insert quantity to order:");
                if (!int.TryParse(Console.ReadLine(), out int quantity))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    return;
                }

                Product p = s_bl.Product.Read(id);
                if (p == null)
                {
                    Console.WriteLine("Product not found.");
                    return;
                }

                BO.ProductInOrder prod = new BO.ProductInOrder()
                {
                    Id = id,
                    ProductName = p.ProductName,
                    BasePrice = p.Price,
                    Amount = quantity,
                    SaleList = p.SaleInProducts
                };

                s_bl.Order.SearchSaleForProduct(prod, preferdCust);
                Console.WriteLine("Sale List: " + string.Join(", ", prod.SaleList));

                s_bl.Order.AddProductToOrder(order, id, quantity);
                s_bl.Order.CalcTotalPrice(order);
                Console.WriteLine("Total Price: " + order.Price);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding product: " + ex.Message);
            }
        }

        public static void finishOrder(bool preferdCust)
        {
            Console.WriteLine("Select an option: \n1. Create a new order \n2. Exit");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Creating a new order 🛒");
                        addNewOrder(preferdCust);
                        break;
                    case 2:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        public static void addNewOrder(bool preferdCust)
        {
            BO.Order order = new BO.Order();
            addProduct(order, preferdCust);
        }
    }
}
