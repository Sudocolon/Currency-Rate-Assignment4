using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Tests
{
    class CurrencyRateControllerTest
    {
        [Test]
        public void PassTest()
        {
            Assert.AreEqual(true, true);
        }
        [Test]
        public void Loop60TimesPerSecondTest()
        {
            System.Threading.Thread.Sleep(1000);
            Assert.AreEqual(60, CurrencyRateController.CurrentTick);
        }
        [Test]
        public void TickRateToMSTest()
        {
            Assert.AreEqual(16, CurrencyRateController.TickRateToMiliseconds(60));
        }
    }
}
