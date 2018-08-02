using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Gold_Badge_Challenge_01
{
    class Program
    {
         static void Main(string[] args)
        {
            Menu item1 = new Menu("Smash Burger", 01, "California famous burger", "Buns, Patty, Salad", 10.99);
            Menu item2 = new Menu("Vegie Burger", 02, "Vegetarian Famous", "Buns, Patty, Salad", 12.99);
            Menu item3 = new Menu("HamBurger", 03, "Only Ham", "Buns, Patty, Salad", 6.99);
            Menu item4 = new Menu("King Crispy", 04, "King Size", "Buns, Patty, Salad", 19.99);

            MenuRepository menuRepo = new MenuRepository();
            List<Menu> items = menuRepo.GetItems();
            menuRepo.AddMenu(item1);
            menuRepo.AddMenu(item2);
            menuRepo.AddMenu(item3);
            menuRepo.AddMenu(item4);

            string answer = "null";
            while(answer != "4")
            {
                Console.WriteLine("Welcome to my Restaurant");
                Console.WriteLine("Choose one of the following: ");
                Console.WriteLine($"1.) Create a menu Item\n" + "2.) Delete a menu item\n" + "3.) List all items on menu");
                int reply1 = int.Parse(Console.ReadLine());

                if (reply1 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the ItemNumber: ");
                    int itemNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the ItemName: ");
                    string itemName = (Console.ReadLine());

                    Console.WriteLine("Enter the Description: ");
                    string description = (Console.ReadLine());

                    Console.WriteLine("Enter the Ingredients: ");
                    string ingredients = (Console.ReadLine());

                    Console.WriteLine("Enter the Price: ");
                    double price = double.Parse(Console.ReadLine());

                    Menu menuObject = new Menu(itemName, itemNumber, description, ingredients, price);
                    menuRepo.AddItems(menuObject);

                    Console.WriteLine("Here is your Item: ");
                    Console.WriteLine($"Number: {itemNumber}\n" + $"Name: { itemName}\n" + $"Description: {description}\n" + $"Ingredients: {ingredients}\n" + $"Price: {price}");
                }

                else if (reply1 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("What number of menu would you like remove?");
                    foreach (Menu item in items)
                    {
                        Console.WriteLine($"{item.ItemNumber}" + $"{item.ItemName}" + $"{item.Price}");
                    }
                    int removeItem = int.Parse(Console.ReadLine());
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i].ItemNumber == removeItem)
                        {
                            menuRepo.DeleteItem(items[i]);
                        }
                    }
                    Console.WriteLine("Here is the new menu list:");
                    foreach (Menu item in items)
                    {
                        Console.WriteLine($"{item.ItemNumber}" + $"{item.ItemName}" + $"{item.Price}");
                    }
                }
            }
        }
    }
}
