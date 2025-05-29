using DO;


namespace BO
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
    public class Product
        
    {
        public int Id { get; init; }
        public string ProductName { get; set; }
        public Categories Category { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
        public List<BO.SaleInProduct> SaleInProducts { get; set; }

        
        public Product( int Id, string ProductName, Categories Category, double Price, int QuantityInStock, List<BO.SaleInProduct> SaleInProducts) {
            this.Id = Id;
            this.ProductName = ProductName;
            this.Category = Category;
            this.Price = Price;
            this.QuantityInStock=QuantityInStock;
            this.SaleInProducts = SaleInProducts;
        }

        public Product() { }    
    }
    
}
