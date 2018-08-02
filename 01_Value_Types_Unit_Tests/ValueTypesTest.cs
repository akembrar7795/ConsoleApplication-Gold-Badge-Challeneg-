using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Value_Types_Unit_Tests
{
    [TestClass]
    public class ValueTypesTest
    {
        [TestMethod]
        public void Integers_SimpleAddition__ShouldAddProperly()
        {
            //-- Arrange
            int x = 3;
            int y = 7;
            int z = 5;


            // -- Act
            int actual = x + y + z;
            int expected = 15;

            //-- Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Strings_CompareTwoStrings_ShouldBeEqual()
        {
            //-- Arrange
            string x = "Hello";
            string y = " ";
            string z = "World";

            //-- Act
            string actual = x + y + z;
            string expected = "Hello World";

            //-- Assert
            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void Booleans_CompareTwoConditionals_ShouldBeEqual()
        {
            //-- Arrange
            bool isOn = true;
            bool isOff = false;


            //-- Act
            if (isOn == true)
                isOff = true;

            bool actual = isOff;
            bool expected = true;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
