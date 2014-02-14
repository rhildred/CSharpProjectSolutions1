using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDApplication
{
    public interface Flyable
    {
        bool canFly();
    }

    class Bat: Mammal, Flyable
    {
        public override string getEnergyMeans()
        {
            return "bugs";
        }

        public bool canFly()
        {
            return true;
        }
    }

    class BarnSwallow : Bird, Flyable
    {
        public override string getEnergyMeans()
        {
            return "bugs";
        }

        public bool canFly()
        {
            return true;
        }
    }
}
