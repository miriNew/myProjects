

namespace Dal;

internal static class Config
{
    public const string dataConfigXML = "data-config";
    

    public static int ProductCode => int.Parse(XmlTools.GetValueByName("ProductCode"));

    public static int SaleCode => int.Parse(XmlTools.GetValueByName("SaleCode"));





}
