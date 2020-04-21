using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vending.Machine.Test
{
    [TestClass]
    public class VendingMachineTest
    {
        private VendingMachine _machine;

        [TestInitialize]
        public void Setup()
        {
            _machine = new VendingMachine();
        }

        [TestMethod]
        public void WhenInsertingADimeThenBalanceIsTenCents()
        {
            _machine.InsertCoin("DIME");

            Assert.AreEqual("$0.10", _machine.DisplayText);
        }
    }
}
