using System;
using _02_Reference_Types_Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Reference_Types_Testa
{
    [TestClass]
    public class PlanTest
    {
        [TestMethod]
        public void Plan_PlanName_ShouldBeSetToString()
        {
            //-- Arrange
            Plan plan = new Plan();
            plan.PlanName = "Komodo Trauma Plan";

            //-- Act
            string actual = plan.PlanName;
            string expected = "Komodo Trauma Plan";


            //-- Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Plan_PlanPremium_ShouldBeCorrectDecimal()
        {
            //-- Arrange
            Plan plan = new Plan();
            plan.Premium = 109.99m;

            //-- Act
            decimal actual = plan.Premium;
            decimal expected = 109.99m;


            //-- Assert
            Assert.AreEqual(expected, actual);
        }

       
    }
}
