using Assignment4.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Tests
{
    class CurrencyRateUpdateTest
    {
        [Test]
        public void PassTest()
        {
            Assert.AreEqual(true, true);
        }
        [Test]
        public void CheckCurrencyPairCount()
        {
            CurrencyRateUpdate.SetCurrencyRateData();
            int pairCount = 0;
            pairCount = CurrencyRateUpdate.pairData.Count;
            Assert.AreEqual(61, pairCount);
        }
        [Test]
        public void CheckUpdateEqualsController()
        {
            CurrencyRateUpdate.SetCurrencyRateData();
            Assert.AreEqual(61, CurrencyRateController.CurrencyData.Count);
        }
    }
}
