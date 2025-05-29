using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
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
    public class Sale
    { 
       public int Code {  get; set; }
        public int ProductId {  get; set; }
        public int MinQuantity {  get; set; }   
        public double Price {  get; set; }  
        public bool InClab { get; set; }    
        public DateTime BeginSale {  get; set; }
        public DateTime EndSale { get; set; }

        public Sale(int Code, int ProductId, int MinQuantity, double Price, bool InClab, DateTime BeginSale, DateTime EndSale)
        {
            this.Code = Code;
            this.ProductId = ProductId;
            this.MinQuantity = MinQuantity;
            this.Price = Price;
            this.InClab = InClab;
            this.EndSale = EndSale;
            this.BeginSale = BeginSale;
        }
        public Sale() { }
        



    }
}
