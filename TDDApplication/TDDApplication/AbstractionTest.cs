using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDApplication
{
    [TestFixture]
    class AbstractionTest
    {
        [Test]
        public void createTiger()
        {
            Animal oTony = new Tiger();
            Assert.IsNotNull(oTony);
        }
        [Test]
        public void testName()
        {
            Animal oTony = new Tiger();
            Assert.AreEqual(oTony.getName(), "Tony");
        }
        [Test]
        public void testReproduction()
        {
            Animal oTony = new Tiger();
            Assert.AreEqual(oTony.getReproductionMethod(), "live birth");
        }
        [Test]
        public void testEnergy()
        {
            Animal oTony = new Tiger();
            Assert.AreEqual(oTony.getEnergyMeans(), "frosted flakes");
        }
        [Test]
        public void testBengal()
        {
            Animal oShereKhan = new BengalTiger();
            Assert.AreEqual(oShereKhan.getName(), "Shere Khan ... King of the jungle");
        }
        [Test]
        public void testBengalEnergy()
        {
            Animal oShereKhan = new BengalTiger();
            Assert.AreEqual(oShereKhan.getEnergyMeans(), "gazelle lightly dusted with frosted flakes");
        }
    }
}
