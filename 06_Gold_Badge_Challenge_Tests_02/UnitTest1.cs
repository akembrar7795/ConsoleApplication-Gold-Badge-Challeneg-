using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Gold_Badge_Challenge_Tests_02
{
    [TestClass]
    public class UnitTest1
    {
        ConsoleApp1.ClaimRepository newClaimRepository;
        [TestInitialize]
        public void Arrange()
        {
            newClaimRepository = new ConsoleApp1.ClaimRepository();
        }

        [TestMethod]
        public void MenuRepository_AddListToMenu_ShouldBeAdded()
        {
            Claim car = new Claim(1, "Car", "Accident", 400.00, DateTime.Parse("10/12/2018"), DateTime.Parse("10/15/2018"), true);
            newClaimRepository.AddList(car);

            var actual = newClaimRepository.GetItems().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MenuRepository_RemoveListFromMenu_ShouldBeRemoved()
        {
            Claim car = new Claim(1,"Car","accident on 463", 1200.00, DateTime.Parse("01/15/1999"), DateTime.Parse("01/16/1999"), true);
            Claim truck = new Claim(1, "Truck", "accident on 469", 2000.00, DateTime.Parse("01/11/1999"), DateTime.Parse("01/17/1999"), true);
            newClaimRepository.AddList(car);
            newClaimRepository.AddList(truck);

            newClaimRepository.RemoveItem(car);

            var actual = newClaimRepository.GetItems().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);

        }
    }
}
