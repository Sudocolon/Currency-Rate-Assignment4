using Assignment4.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment4.Classes.XMLParser;

namespace Assignment4.Classes
{
    public static class CompareTargetRate
    {
        public static Currency PairWatching;
        public static string TargetPairName;
        static bool TargetIsAbove;
        public static float TargetValue;
        public static bool CheckingTarget = false;
        static CompareTargetRate()
        {

        }
        public static void SetTarget(string targetName, float targetValue)
        {
            CheckingTarget = true;
            TargetValue = targetValue;
            TargetPairName = targetName;
            PairWatching = CurrencyRateController.CurrencyData[TargetPairName];
            if (PairWatching.Bid >= TargetValue)
            {
                TargetIsAbove = false;
            }
            else
            {
                TargetIsAbove = true;
            }
        }
        public static void CheckTarget()
        {
            //Console.WriteLine("checkingtarget1:" + CheckingTarget);
            if (CheckingTarget)
            {
                //Console.WriteLine("checkingtarget2:" + CheckingTarget);
                PairWatching = CurrencyRateController.CurrencyData[TargetPairName];
                //Console.WriteLine(PairWatching.Bid + " " + TargetValue);
                if (TargetIsAbove)
                {
                    if (TargetValue <= PairWatching.Bid)
                    {
                        CurrencyRateView.TargetNotification();
                        CheckingTarget = false;
                        //Console.WriteLine("checkingtarget3A:" + CheckingTarget);
                    }
                }
                else
                {
                    if (TargetValue >= PairWatching.Bid)
                    {
                        CurrencyRateView.TargetNotification();
                        CheckingTarget = false;
                        //Console.WriteLine("checkingtarget3B:" + CheckingTarget);
                    }
                }
                //Console.WriteLine("checkingtarget3:" + CheckingTarget);
            }
        }
    }
}
