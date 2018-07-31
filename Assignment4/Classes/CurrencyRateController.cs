using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace Assignment4.Tests
{
    public static class CurrencyRateController
    {
        public static int CurrentTick = 0;
        public static int UpdateRate = 60;
        static BackgroundWorker Worker = new BackgroundWorker();
        static CurrencyRateController()
        {
            Worker.DoWork += Tick;
            Worker.RunWorkerAsync("Tick");
        }
        static void Tick(object sender, DoWorkEventArgs ev)
        {
            Console.WriteLine("Foo");
            Thread.Sleep(1000);
            Worker.RunWorkerAsync("Tick");
        }
        internal static int TickRateToMiliseconds(int rate)
        {
            float conversionOutput = 1F / rate * 1000;
            return (int)conversionOutput;
        }
    }
}
