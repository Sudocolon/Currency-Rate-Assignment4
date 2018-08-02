using Assignment4.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment4.Classes.XMLParser;

namespace Assignment4.Classes
{
    public static class CurrencyRateUpdate
    {
        readonly static string url = "http://rates.fxcm.com/RatesXML";
        public static Dictionary<string, Currency> PairData = new Dictionary<string, Currency>();
        static CurrencyRateUpdate()
        {

        }
        public static void SetCurrencyRateData()
        {
            PairData = XMLParser.ParseCurrencyXML(CurrencyRateRetriever.RetrieveXml(url));
            CurrencyRateController.CurrencyData = PairData;
        }
    }
}
