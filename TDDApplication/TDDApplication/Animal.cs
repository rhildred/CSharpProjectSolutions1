using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDApplication
{
    public abstract class Animal
    {
        public abstract string getReproductionMethod();
        public abstract string getEnergyMeans();
        protected string sName = null;
        public virtual string getName()
        {
            return sName;
        }
        public void setName(string sNewName)
        {
            sName = sNewName;
        }
    }

    public abstract class Mammal : Animal
    {
        public override string getReproductionMethod()
        {
            return "live birth";
        }
    }

    public abstract class Bird : Animal
    {
        public override string getReproductionMethod()
        {
            return "I come from an egg";
        }
    }

    public class Tiger : Mammal
    {
        public Tiger()
        {
            setName("Tony");
        }
        public override string getEnergyMeans()
        {
            return "frosted flakes";
        }
    }

    public class BengalTiger: Tiger
    {
        public BengalTiger()
        {
            setName("Shere Khan");
        }
        public override string getName()
        {
            return base.getName() + " ... King of the jungle";
        }
        public override string getEnergyMeans()
        {
            return "gazelle lightly dusted with frosted flakes";
        }
    } 
}
