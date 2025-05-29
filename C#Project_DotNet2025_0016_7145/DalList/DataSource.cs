

namespace Dal;
using DO;

static internal class DataSource
{
   internal static List<Sale?> Sales = new List<Sale?>();
   internal static List<Customer?> Customers = new List<Customer?>();
   internal static List<Product?> Products = new List<Product?>();




   internal static class Config
    {
        internal const int ProductId = 100;
        internal const int SaleId = 100;

        private static int ProdIndex = ProductId;
        private static int SaleIndex = SaleId;


        public static int productCode
        {
            get
            {
                return ProdIndex++;
            }
        }

        public static int SaleCode
        {
            get
            {
                return SaleIndex++;
            }
        }



    }

}

