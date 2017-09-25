using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceBillet;

namespace UnitTestBroPriser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BilPrisStorebælt()
        {
            var service1 = new Service1();

            int pris = service1.GetBilPrisStorebælt();

            Assert.AreEqual(240, pris);
        }

        [TestMethod]
        public void MCPrisØresund()
        {
            var service1 = new Service1();

            int pris = service1.GetMCPrisØresund();

            Assert.AreEqual(210, pris);
        }
    }
}
