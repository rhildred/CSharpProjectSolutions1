using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDApplication
{
    [TestFixture]
    class DelegateTest
    {
        [Test]
        public void testNonRipoff()
        {
            CalculateFee calc = new CalculateFee(FeeCalculator.RipoffFee);
            decimal fees = calc(100);
            Assert.AreEqual(10, fees);
        }
        [Test]
        public void testRealRipoff()
        {
            CalculateFee calc = new CalculateFee(FeeCalculator.RipoffFee);
            decimal fees = calc(-1);
            Assert.AreEqual(100, fees);
        }
        [Test]
        public void testFriendlyNegativeFee()
        {
            CalculateFee calc = new CalculateFee(FeeCalculator.FriendlyFee);
            decimal fees = calc(-1);
            Assert.AreEqual(1, fees);
        }
        [Test]
        public void testFriendlyPositiveFee()
        {
            CalculateFee calc = new CalculateFee(FeeCalculator.FriendlyFee);
            decimal fees = calc(100);
            Assert.AreEqual(1, fees);
        }
    }
}
