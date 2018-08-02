using System;
using _03_OOP_Defining_Classes_Exercise_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_OOP_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Excercise_1_CarTests
    {
        [TestMethod]
        public void Car_CarMake_ShouldBeSetToString()
        {
            //-- Arrange
            Car car = new Car("Ferrari", "Testarose", 2000);

            //-- Act
            string expected = "Ferrari";
            string actual = car.CarMake;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Car_CarModel_ShouldBeSetToString()
        {
            //-- arrange
            Car car = new Car("Ferrari", "Testarose", 2000);

            //-- act
            string expected = "Testarose";
            string actual = car.CarModel;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Car_CarYear_ShouldBeSetToint()
        {
            //-- arrange
            Car car = new Car("Ferrari", "Testarose", 2000);

            //-- act
            int expected = 2000;
            int actual = car.CarYear;

            //--assert
            Assert.AreEqual(expected, actual);
        }
    }
}
