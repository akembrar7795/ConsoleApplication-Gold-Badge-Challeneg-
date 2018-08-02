using System;
using Assessment_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment_1_Tests
{
    [TestClass]
    public class PhoneTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Phone phone = new Phone("Apple", "Iphone 10", 1200);

            string expected = "Apple";
            string actual = phone.Maker;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Phone_Model_ShouldComeToString()
        {
            Phone phone = new Phone("Apple", "Iphone 10", 1200);

            string expected = "Iphone 10";
            string actual = phone.Model;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Phone_Cost_ShouldComeToInt()
        {
            Phone phone = new Phone("Apple", "Iphone 10", 1200);

            int expected = 1200;
            int actual = phone.Cost;

            Assert.AreEqual(expected, actual);
        }
    }
}
