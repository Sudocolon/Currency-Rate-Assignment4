using Assignment4.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Tests
{
    class XMLParserTest
    {
        [Test]
        public void PassTest()
        {
            Assert.AreEqual(true, true);
        }
        [Test]
        public void CountAllPairs()
        {
            string url = "http://rates.fxcm.com/RatesXML";
            int pairCount = 0;
            pairCount = XMLParser.ParseCurrencyXML(CurrencyRateRetriever.RetrieveXml(url)).Count;
            //There are 61 pairs in the document
            Assert.AreEqual(61, pairCount);
        }
    }
}
