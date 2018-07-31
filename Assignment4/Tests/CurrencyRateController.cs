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
        static CurrencyRateController()
        {
            Thread UpdateThread = new Thread(Update);
            System.Diagnostics.Debug.WriteLine("Start Thread");
            UpdateThread.Start();
        }

        internal static void Update()
        {
            while (true)
            {
                Thread.Sleep(TickRateToMiliseconds(60));
                CurrentTick++;
                System.Diagnostics.Debug.WriteLine(CurrentTick);
            }
        }
        internal static int TickRateToMiliseconds(int rate)
        {
            float conversionOutput = 1F / rate * 1000;
            return (int)conversionOutput;
        }
    }
}
