using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDApplication
{
    [TestFixture]
    class TaxTest
    {
        [Test]
        public void testABTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "AB");
            Assert.AreEqual(sResult, "10.50");
        }
        [Test]
        public void testBCTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "BC");
            Assert.AreEqual(sResult, "11.20");
        }
        [Test]
        public void testMBTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "MB");
            Console.WriteLine(sResult + " Was result");
            Assert.AreEqual(sResult, "11.30");
        }
        [Test]
        public void testNBTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "NB");
            Assert.AreEqual(sResult, "11.30");
        }
        [Test]
        public void testNLTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "NL");
            Console.WriteLine(sResult + " Was result");
            Assert.AreEqual(sResult, "11.30");
        }
        [Test]
        public void testNSTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "NS");
            Assert.AreEqual(sResult, "11.50");
        }
        [Test]
        public void testNTTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "NT");
            Assert.AreEqual(sResult, "10.50");
        }
        [Test]
        public void testNUTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "NU");
            Assert.AreEqual(sResult, "10.50");
        }
        [Test]
        public void testONTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn);
            Assert.AreEqual(sResult, "11.30");
        }
        [Test]
        public void testPEITax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "PE");
            Assert.AreEqual(sResult, "11.40");
        }
        [Test]
        public void testQCTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "QC");
            Assert.AreEqual(sResult, "11.50");
        }
        [Test]
        public void testSKTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "SK");
            Assert.AreEqual(sResult, "11.00");
        }
        [Test]
        public void testYKTax()
        {
            string sIn = "10";
            string sResult = CanadianTax.getTax(sIn, "YK");
            Assert.AreEqual(sResult, "10.50");
        }
    }
}
