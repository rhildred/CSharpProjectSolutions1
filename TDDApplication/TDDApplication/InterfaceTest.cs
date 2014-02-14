using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDApplication
{
    [TestFixture]
    class InterfaceTest
    {
        [Test]
        public void testDracula()
        {
            Animal oDracula = new Bat();
            Assert.IsNotNull(oDracula);
        }
        [Test]
        public void testDraculaFlying()
        {
            Flyable oDracula = new Bat();
            Assert.IsTrue(oDracula.canFly());
        }
        [Test]
        public void testBarnSwallow()
        {
            Animal oSwallow = new BarnSwallow();
            Assert.IsNotNull(oSwallow);
        }
        [Test]
        public void testBarnSwallowFlying()
        {
            Flyable oBarnSwallow = new BarnSwallow();
            Assert.IsTrue(oBarnSwallow.canFly());
        }
        [Test]
        public void testEating()
        {
            Animal oDracula = new Bat(), oBarnSwallow = new BarnSwallow();
            Assert.AreEqual(oDracula.getEnergyMeans(), oBarnSwallow.getEnergyMeans());
        }
    }
}
