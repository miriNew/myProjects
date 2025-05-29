using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DO
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="Name">שם לקוח</param>
    /// <param name="Address">כתובת לקוח</param>
    /// <param name="Phone">טלפון לקוח</param>
    public record Customer
        (int Id, string Name, string Address, int Phone)
    {
        public Customer():this(0,"מירי","נתיבות המשפט 46",0527653108)
        {
                
        }
    }
   
}