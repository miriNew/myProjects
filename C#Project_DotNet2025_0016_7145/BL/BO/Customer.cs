using System.Text;
using System.Threading.Tasks;

namespace BO
{
   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name">שם לקוח</param>
        /// <param name="Address">כתובת לקוח</param>
        /// <param name="Phone">טלפון לקוח</param>
        public class Customer
        {
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public Customer(int id, string name, string address, int phone)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
        }   
        public Customer() { }
    }
    
}
