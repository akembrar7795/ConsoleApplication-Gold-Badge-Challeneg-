using System;
using _03_OOP_Defining_Classes_Exercise_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_OOP_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Excercise_2_CustomerTests
    {

        [TestMethod]
        public void Customer_SendMessage2_ShouldReturnString()
        {
            //-- Arrange
            Customer customer = new Customer("ravinder", "Ranu", 1, 4);

            //-- Act
            string expected = "Thanks for being a member";
            string actual = customer.SendCustomerMessage();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SendMessage_ShouldReturnString()
        {
            //-- Arrange
            Customer customer = new Customer("Akemjot", "brar", 1, 6);

            //-- Act
            string expected = "Thank you for being a Gold Member";
            string actual = customer.SendCustomerMessage();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_FirstName_ShouldSetName()
        {
            Customer customer = new Customer("Akemjot", "Brar", 20, 5);

            string expected = "Akemjot";
            string actual = customer.FirstName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_LastName_ShouldSetLastName()
        {
            Customer customer = new Customer("Akemjot", "Brar", 21, 6);

            string expected = "Brar";
            string actual = customer.LastName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Customer customer = new Customer("Akemjot", "Brar", 1, 5);

            int expected = 1;
            int actual = customer.IDNumber;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Customer customer = new Customer("Akemjot", "Brar", 1, 5);

            int expected = 5;
            int actual = customer.NumberOfYearsUsingTomado;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Customer ID can not be a negative or zero.")]
        public void Customer_CustomerID_ShouldThrowException()
        {
            //Arrange

            Customer customer = new Customer("Akemjot", "Brar", -1, 15);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Year can not be a negative. ")]
        public void Customer_NumberOfYearsWithTomado_ShouldThrowException()
        {
            Customer customer = new Customer("Akemjot", "Brar", -1, -5);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),"Name can not be null and have space")]
        public void Customer_FirstName_ShouldThrowException()
        {
            Customer customer = new Customer(" ", "sidhu", 1 , 20);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "You must enter a customer lastname")]
        public  void Customer_LastName_ShouldThrowException()
        {
            Customer customer = new Customer("Akemjot", " ", 21, 23);
        }
    }
}
