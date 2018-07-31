using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assignment4.Classes
{
    public static class CurrencyRateRetriever
    {
        static string Url;
        static XmlDocument Xml;
        static CurrencyRateRetriever()
        {
            Xml = new XmlDocument();
        }
        public static void SetUrl(string url)
        {
            Url = url;
        }
        public static string GetUrl()
        {
            return Url;
        }
        public static XmlDocument GetXml()
        {
            return Xml;
        }
        public static void RetrieveXml(string url)
        {
            Xml.Load(url);
        }
    }
}
