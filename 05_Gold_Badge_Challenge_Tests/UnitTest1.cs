using System;
using _05_Gold_Badge_Challenge_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Gold_Badge_Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {
        _05_Gold_Badge_Challenge_01.MenuRepository newMenuRepository;
        [TestInitialize]
        public void Arrange()
        {
            newMenuRepository = new _05_Gold_Badge_Challenge_01.MenuRepository();
        }
        
        [TestMethod]
        public void MenuRepository_AddMenuToList_ShouldAddToListOneByOne()
        {
            Menu taco = new Menu("taco", 1, "Wild naked crunchy tacos", "Meat, taco, cheese, tacosauce", 12.99);
            newMenuRepository.AddMenu(taco);

            var actual = newMenuRepository.GetItems().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Menurepository_RemoveItemFromList_ShouldRemoveItem()
        {
            Menu burger = new Menu("Burger", 1, "Cheesy Burger", "Cheese, Bun", 11.99);
            Menu maggie = new Menu("Magggie", 2, "Noodles", "Masala", 15.99);
            Menu taco = new Menu("Taco", 1, "Miled Taco", "taco, sauces", 10.99);
            newMenuRepository.AddMenu(burger);
            newMenuRepository.AddMenu(maggie);
            newMenuRepository.AddMenu(taco);

            newMenuRepository.DeleteItem(taco);

            var actual = newMenuRepository.GetItems().Count;
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }
       
    }
}
