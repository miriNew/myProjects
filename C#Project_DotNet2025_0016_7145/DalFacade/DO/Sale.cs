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
    /// <param name="Code"></param>
    /// <param name="ProductId"></param>
    /// <param name="MinQuantity"></param>
    /// <param name="Price"></param>
    /// <param name="InClab"></param>
    /// <param name="BeginSale"></param>
    /// <param name="EndSale"></param>
    public record Sale
        (int Code, int ProductId, int MinQuantity, double Price, bool InClab, DateTime BeginSale, DateTime EndSale)
    {
        public Sale():this(0,12,20,50,true,DateTime.Now,DateTime.Now) 
        {
                
        }

    }

}
