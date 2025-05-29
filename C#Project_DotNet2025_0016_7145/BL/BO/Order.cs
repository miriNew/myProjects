using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
       public bool PreferedCustomer { get; set; }
        public double Price { get; set; }
        public List<ProductInOrder> ProductInOrder { get; set; }
    }
}
