using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
      public int Id { get; set; }
        public string ProductName { get; set; }
        public double BasePrice { get; set; }
        public int Amount { get; set; }
        public List<SaleInProduct> SaleList { get; set; }
        public double FinalPrice { get; set; }
        
    }
}
