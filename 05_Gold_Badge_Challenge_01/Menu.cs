using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Gold_Badge_Challenge_01
{
    public class Menu
    {
        public int ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        //constructor
        public Menu( string itemname, int itemnumber, string description, string ingredients, double price)
        {
            ItemNumber = itemnumber;
            ItemName = itemname;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }
    }

}
