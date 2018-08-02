using Assignment4.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using static Assignment4.Classes.XMLParser;

namespace Assignment4.Tests
{
    public static class CurrencyRateController
    {
        readonly static string url = "http://rates.fxcm.com/RatesXML";
        public static int CurrentTick = 0;
        public static int UpdateRate = 1;
        public static Dictionary<string, Currency> CurrencyData = new Dictionary<string, Currency>();
        static CurrencyRateController()
        {

        }
        public static void Tick()
        {
            CurrentTick++;
            CurrencyData = XMLParser.ParseCurrencyXML(CurrencyRateRetriever.RetrieveXml(url));
            //Console.WriteLine("Tick:" + CurrentTick);
            //Console.WriteLine("Count:" + CurrencyData.Count);
        }
    }
}
