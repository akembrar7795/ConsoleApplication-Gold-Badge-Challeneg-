using System;
using _07_Gold_Badge_Challenge_03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Gold_Badge_Challenge_Test_03
{
    [TestClass]
    public class UnitTest1
    {
        _07_Gold_Badge_Challenge_03.OutingsRepository newoutingsRepository;
        [TestInitialize]
        public void Arrange()
        {
            newoutingsRepository = new _07_Gold_Badge_Challenge_03.OutingsRepository();
        }


        [TestMethod]
        public void OutingsRepository_AddOutingToList_ShoulBeAdded()
        {
            Outing golf = new Outing("golf", 20, DateTime.Parse("01/10/2018"), 10.00, 200.00);
            newoutingsRepository.addOutingToList(golf);

            var actual = newoutingsRepository.getList().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OutingsRepository_RemoveItemFromList_ShouldBeRemoved()
        {
            Outing golf = new Outing("Golf", 15, DateTime.Parse("10/10/2018"), 10.00, 150.00);
            Outing ammusementPark = new Outing("AmmusementPark", 10, DateTime.Parse("11/10/2018"), 20.00, 200.00);
            Outing concert = new Outing("Concert", 5, DateTime.Parse("12/10/2018"), 10.00, 50.00);
            Outing bowling = new Outing("Bowling", 15, DateTime.Parse("12/10/2018"), 20.00, 300.00);
            newoutingsRepository.addOutingToList(golf);
            newoutingsRepository.addOutingToList(ammusementPark);
            newoutingsRepository.addOutingToList(concert);
            newoutingsRepository.addOutingToList(bowling);

            newoutingsRepository.removeOutingFromList(concert);

            var actual = newoutingsRepository.getList().Count;
            var expected = 3;

            Assert.AreEqual(expected, actual);




        }
    }
}
