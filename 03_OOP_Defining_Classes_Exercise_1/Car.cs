using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP_Defining_Classes_Exercise_1
{
    public class Car
    {
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }

        public Car(string make, string model, int year)
        {
            CarMake = make;
            CarModel = model;
            CarYear = year;
        }
        
    }
}
