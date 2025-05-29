using DalApi;
using DO;
using System.Reflection;
using System.Xml.Linq;
using Tools;

namespace Dal;

internal class SaleImplementation:ISale
{
    
        private const string SALE = "Sale";
        private const string CODE = "Code";
        private const string PRODUCT_ID = "ProductId";
        private const string MIN_QUANTITY = "MinQuantity";
        private const string PRICE = "Price";
        private const string IN_CLAB = "InClab";
        private const string BEGIN_SALE = "BeginSale";
        private const string END_SALE = "EndSale";

        const string PATH_SALE = "../xml/sales.xml";
        XElement salesXml = XElement.Load(PATH_SALE);

        public int Create(Sale item)
        {
            try
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

                XElement Sale = new XElement(SALE,
                    new XElement(CODE, Config.SaleCode),
                    new XElement(PRODUCT_ID, item.ProductId),
                    new XElement(MIN_QUANTITY, item.MinQuantity),
                    new XElement(PRICE, item.Price),
                    new XElement(IN_CLAB, item.InClab),
                    new XElement(BEGIN_SALE, item.BeginSale),
                    new XElement(END_SALE, item.EndSale)
                    );
                salesXml.Add(Sale);
                salesXml.Save(PATH_SALE);

                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Sale {item.Code} created successfully");
                return item.Code;
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

                Sale existingSale = Read(id);
                if (existingSale == null)
                {
                    //throw new Dal_idNotFound("The sale does not exist in the system.");
                }

                var saleToDelete = salesXml.Descendants(SALE).FirstOrDefault(s => int.Parse(s.Element(CODE).Value) == id);

                if (saleToDelete != null)
                {
                    saleToDelete.Remove();
                    LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Sale {id} deleted successfully");

                }
                salesXml.Save(PATH_SALE);
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public Sale? Read(int id)
        {
            try
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
                var existingSale = salesXml.Descendants(SALE).FirstOrDefault(s => int.Parse(s.Element(CODE).Value) == id);

                if (existingSale == null)
                {
                    //throw new Dal_idNotFound("The sale does not exist in the system.");
                }
                Sale sale = new Sale()
                {
                    Code = int.Parse(existingSale.Element(CODE)?.Value ?? "0"),
                    ProductId = int.Parse(existingSale.Element(PRODUCT_ID)?.Value ?? "0"),
                    MinQuantity = int.Parse(existingSale.Element(MIN_QUANTITY)?.Value ?? "0"),
                    Price = int.Parse(existingSale.Element(PRICE)?.Value ?? "0"),
                    InClab = bool.Parse(existingSale.Element(IN_CLAB)?.Value ?? "0"),
                    BeginSale = DateTime.Parse(existingSale.Element(BEGIN_SALE)?.Value ?? "0"),
                    EndSale = DateTime.Parse(existingSale.Element(END_SALE)?.Value ?? "0")

                };
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
                return sale;
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            try
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

                Sale matchingSale = salesXml.Descendants(SALE)
                     .Select(saleXml => new Sale()
                     {
                         Code = int.Parse(saleXml.Element(CODE)?.Value ?? "0"),
                         ProductId = int.Parse(saleXml.Element(PRODUCT_ID)?.Value ?? "0"),
                         MinQuantity = int.Parse(saleXml.Element(MIN_QUANTITY)?.Value ?? "0"),
                         Price = int.Parse(saleXml.Element(PRICE)?.Value ?? "0"),
                         InClab = bool.Parse(saleXml.Element(IN_CLAB)?.Value ?? "0"),
                         BeginSale = DateTime.Parse(saleXml.Element(BEGIN_SALE)?.Value ?? "0"),
                         EndSale = DateTime.Parse(saleXml.Element(END_SALE)?.Value ?? "0")

                     }).FirstOrDefault(sale => filter(sale)) ?? new Sale();
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
                return matchingSale;
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }


    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
        {
            try
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
                List<Sale> allSales = salesXml.Descendants(SALE).Select(saleXml => new Sale()
                {
                    Code = int.Parse(saleXml.Element(CODE)?.Value ?? "0"),
                    ProductId = int.Parse(saleXml.Element(PRODUCT_ID)?.Value ?? "0"),
                    MinQuantity = int.Parse(saleXml.Element(MIN_QUANTITY)?.Value ?? "0"),
                    Price = int.Parse(saleXml.Element(PRICE)?.Value ?? "0"),
                    InClab = bool.Parse(saleXml.Element(IN_CLAB)?.Value ?? "0"),
                    BeginSale = DateTime.Parse(saleXml.Element(BEGIN_SALE)?.Value ?? "0"),
                    EndSale = DateTime.Parse(saleXml.Element(END_SALE)?.Value ?? "0")

                }).ToList();
                if (filter != null)
                {
                    allSales = allSales.Where(filter).ToList();
                }
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
                return allSales;

            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
                throw new Exception("An error occurred while reading Sales: " + ex.Message);
            }
        }

 

    public void Update(Sale item)
        {
            try
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
                var existingSale = salesXml.Descendants(SALE).FirstOrDefault(s => int.Parse(s.Element(CODE).Value) == item.Code);

                if (existingSale == null)
                {
                    //throw new Dal_idNotFound("The sale does not exist in the system.");
                }
                existingSale.SetElementValue(PRODUCT_ID, item.ProductId);
                existingSale.SetElementValue(MIN_QUANTITY, item.MinQuantity);
                existingSale.SetElementValue(PRICE, item.Price);
                existingSale.SetElementValue(IN_CLAB, item.InClab);
                existingSale.SetElementValue(BEGIN_SALE, item.BeginSale);
                existingSale.SetElementValue(END_SALE, item.EndSale);

                salesXml.Save(PATH_SALE);
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Sale {item.Code} updated successfully");


            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }



}


