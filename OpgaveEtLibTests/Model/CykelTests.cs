using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpgaveEtLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveEtLib.Model.Tests
{
    [TestClass()]
    public class CykelTests
    {
        private Cykel cykel;

        [TestInitialize]
        public void init()
        {
            cykel = new Cykel(1,"Rød",10500,3);
        }

        //[TestMethod()]
        //public void CykelTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod]
        public void CunstructureCykelTest()
        {
            Assert.ThrowsException<NullReferenceException>(() => new Cykel(1, null, 10000, 5));

        }

        [TestMethod]
        public void IdTest()
        {
            Assert.AreEqual(1,cykel.Id);
        }

        [TestMethod]
        public void FarveTest()
        {
            Assert.AreEqual("Rød", cykel.Farve);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel.Farve = "");
            Assert.ThrowsException<NullReferenceException>(() => cykel.Farve = null);
        }

        [TestMethod]
        public void GearTest()
        {
            Assert.AreEqual(3,cykel.Gear);
            cykel.Gear = 32;
            Assert.AreEqual(32, cykel.Gear);
            cykel.Gear = 15;
            Assert.AreEqual(15, cykel.Gear);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel.Gear = 33);
        }

        [TestMethod]
        public void PriceTest()
        {
            Assert.AreEqual(10500, cykel.Price);
            cykel.Price = 1;
            Assert.AreEqual(1, cykel.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel.Price = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel.Price = -1);
        }

        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("cykel med 3 gear til 10500", cykel.ToString());
        }
    }
}