using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assignment4.Classes
{
    public static class XMLParser
    {
        public struct Currency
        {
            public float Bid;
            public float Ask;
            public float High;
            public float Low;
            public float Direction;
            public string Last;
        }
        public static Dictionary<string, Currency> ParseCurrencyXML(XmlDocument xml)
        {
            Dictionary<string, Currency> parseData = new Dictionary<string, Currency>();
            XmlNodeList xmlNodes = xml.DocumentElement.SelectNodes("/Rates/Rate");
            foreach (XmlNode xmlNode in xmlNodes)
            {
                Currency currency = new Currency
                {
                    Bid = float.Parse(xmlNode.SelectSingleNode("Bid").InnerText),
                    Ask = float.Parse(xmlNode.SelectSingleNode("Ask").InnerText),
                    High = float.Parse(xmlNode.SelectSingleNode("High").InnerText),
                    Low = float.Parse(xmlNode.SelectSingleNode("Low").InnerText),
                    Direction = float.Parse(xmlNode.SelectSingleNode("Direction").InnerText),
                    Last = xmlNode.SelectSingleNode("Last").InnerText
                };
                parseData.Add(xmlNode.Attributes["Symbol"].Value, currency);
            }
            return parseData;
        }
    }
}
