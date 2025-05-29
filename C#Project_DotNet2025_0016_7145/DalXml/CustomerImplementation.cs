using DalApi;
using DO;
using System.Reflection;
using System.Xml.Serialization;
using Tools;
namespace Dal;

internal class CustomerImplementation : ICustomer
{
        const string PATH_CUSTOMER = "../xml/customers.xml";
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
        public int Create(Customer item)
        {
            
        try {


            //LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
            LogManager.WriteToLog("DalList", MethodBase.GetCurrentMethod().Name, "start");
            List<Customer> customers = ReadAll() ?? new List<Customer>();
                customers.Add(item);

                using (FileStream xmlWrite = new FileStream(PATH_CUSTOMER, FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(xmlWrite, customers);
                }
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"customer {item.Id} created successfully");
                return item.Id;
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
                List<Customer> customers = ReadAll() ?? new List<Customer>();
                Customer c = customers.FirstOrDefault(x => x.Id == id);
                if (c == null)
                {
                    //throw new Dal_idNotFound("The product does not exist in the system.");
                }
                customers.Remove(c);

                using (FileStream xmlwrite = new FileStream(PATH_CUSTOMER, FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer = new XmlSerializer(typeof(Customer));
                }
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"customer {id} deleted successfully");
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
                Console.WriteLine(ex.Message);
            }

        }

        public Customer? Read(int id)
        {
            try
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
                List<Customer> customers = ReadAll() ?? new List<Customer>();
                Customer c = customers.FirstOrDefault(x => x.Id == id);
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");

                return c;

            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            try
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
                List<Customer> customers = ReadAll() ?? new List<Customer>();
                Customer c = customers.FirstOrDefault(filter) ?? new Customer();

                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");

                return c;
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
                throw new Exception(ex.Message);
            }

        }


        public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
        {
            try
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
                List<Customer> customers;
                using (FileStream fs = new FileStream(PATH_CUSTOMER, FileMode.Open, FileAccess.Read))
                {
                    customers = (List<Customer>)xmlSerializer.Deserialize(fs);
                }
                if (filter != null)
                {
                    return customers.Where(filter).ToList();
                }
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
                return customers;

            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
        public void Update(Customer item)
        {
            try
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
                List<Customer> customers = ReadAll() ?? new List<Customer>();
                Customer c = customers.FirstOrDefault(x => x.Id == item.Id);
                if (c == null)
                {
                    //throw new Dal_idNotFound("The Product does not exist in the system.");
                }
                customers.Remove(c);
                customers.Add(item);

                using (FileStream xmlWrite = new FileStream(PATH_CUSTOMER, FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(xmlWrite, customers);
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

    }


