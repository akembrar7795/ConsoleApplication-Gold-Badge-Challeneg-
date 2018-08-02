using System;
using _02_Reference_Types_Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Reference_Types_Testa
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //-- Arrange
            Employee employee = new Employee();
            employee.FirstName = "Akemjot";

            //-- Act
            string actual = employee.FirstName;
            string expected = "Akemjot";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //-- Arrange
            Employee employee = new Employee();
            employee.LastName = "Brar";

            //-- Act 
            string actual = employee.LastName;
            string expected = "Brar";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //-- arrange
            Employee employee = new Employee();
            employee.EmployeeID = 123456;

            int actual = employee.EmployeeID;
            int expected = 123456;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod4()
        {
            //-- arrange
            Employee employee = new Employee();
            employee.age = 16;

            int actual = employee.age;
            int expected = 16;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Employee employee = new Employee();
            employee.NumberOfYearsExperience = 20;

            int actual = employee.NumberOfYearsExperience;
            int expected = 20;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod6()
        {
            Employee employee = new Employee();
            employee.FirstName = "Akemjot";
            employee.LastName = "Brar";

            string actual = employee.GetFullName();
            string expected = "Akemjot Brar";

            Assert.AreEqual(expected, actual);

        }
    }
}
