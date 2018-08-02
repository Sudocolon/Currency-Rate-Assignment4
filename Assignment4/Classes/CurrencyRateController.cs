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
        public static int CurrentTick = 0;
        public static int UpdateRate = 1;
        public static Dictionary<string, Currency> CurrencyData = new Dictionary<string, Currency>();
        static CurrencyRateController()
        {
            CurrencyRateUpdate.SetCurrencyRateData();
            CompareTargetRate.SetTarget("EURUSD", 1.16154F);
        }
        public static void Tick()
        {
            CurrentTick++;
            CurrencyRateUpdate.SetCurrencyRateData();
            CompareTargetRate.CheckTarget();

            //Console.WriteLine("Tick:" + CurrentTick);
            //Console.WriteLine("Count:" + CurrencyData.Count);
        }
    }
}
