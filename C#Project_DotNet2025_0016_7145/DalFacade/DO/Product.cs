using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    /// <summary>
    /// פרטי מוצר
    /// <summary>
    /// </summary>
    /// <param name="Id">מספר מזהה יחודי למוצר</param>
    /// <param name="ProductName">שם מוצר</param>
    /// <param name="Category">קטגוריה</param>
    /// <param name="Price">מחיר</param>
    /// <param name="QuantityInStock">כמות במלאי</param>
    public record Product
        (int Id, string ProductName, Categories Category, double Price, int QuantityInStock)
    {
        public Product():this(0,"table",Categories.livingRoom,5000,10)
        {
                
        }
    }

}
