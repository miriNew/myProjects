

using DalApi;
using System.Xml.Linq;

namespace Dal;

internal static class XmlTools
{
    public static string GetValueByName(string name)
    {

        XElement dataConfig = XElement.Load(Config.dataConfigXML) ??
             throw new DalConfigException("data-config.xml file is not found");

        int val = int.Parse(dataConfig.Element(name)?.Value ?? throw new DalConfigException("<dal> element is missing")) +1;
        dataConfig.Element(name)?.SetValue(val);
        dataConfig.Save(Config.dataConfigXML);
        return val.ToString();
    }

}
