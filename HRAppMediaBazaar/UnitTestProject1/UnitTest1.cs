using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockAppMediaBazaar;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ShiftManagement sm = new ShiftManagement();
            
            Assert.AreEqual(1, sm.GetNrOfShiftsPerDay());
        }
    }
}
