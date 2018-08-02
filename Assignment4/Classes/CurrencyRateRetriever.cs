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
        static CurrencyRateRetriever()
        {

        }
        public static XmlDocument RetrieveXml(string url)
        {
            XmlDocument Xml = new XmlDocument();
            Xml.Load(url);
            return Xml;
        }
    }
}
