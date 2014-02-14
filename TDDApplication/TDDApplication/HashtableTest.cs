using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections;

namespace TDDApplication
{
    [TestFixture]
    class HashtableTest
    {
        [Test]
        public void hashTableExists()
        {
            Hashtable oTable = new Hashtable();
            Assert.IsNotNull(oTable);
        }
        [Test]
        public void addTestOfHashtable()
        {
            Hashtable oTable = new Hashtable();
            oTable.Add("test", "testing");
            Assert.AreEqual("testing", oTable["test"]);
        }
        [Test]
        public void foreachHashTable()
        {
            Hashtable oTable = new Hashtable();
            oTable.Add("test", "testing");
            string sOut = "[";
            foreach (string name in oTable.Keys)
            {
                sOut += "{\"" + name + "\":\"" + oTable[name] + "\"}";
            }
            sOut += "]";
            Console.WriteLine(sOut + " was result");
            Assert.AreEqual(sOut, "[{\"test\":\"testing\"}]");
        }
        [Test]
        public void deleteTestOfHashtable()
        {
            Hashtable oTable = new Hashtable();
            oTable.Add("test", "testing");
            oTable.Remove("test");
            Assert.IsNull(oTable["test"]);
        }
    }
}
