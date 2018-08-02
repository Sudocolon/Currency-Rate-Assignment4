using Assignment4.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assignment4.Tests
{
    class CurrencyRateRetrieverTest
    {
        [Test]
        public void PassTest()
        {
            Assert.AreEqual(true, true);
        }
        [Test]
        public void GetXMLTest()
        {
            XmlDocument emptyXML = new XmlDocument();
            string url = "http://rates.fxcm.com/RatesXML";
            Assert.AreNotEqual(emptyXML, CurrencyRateRetriever.RetrieveXml(url));
        }
    }
}
