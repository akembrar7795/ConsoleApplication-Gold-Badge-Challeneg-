using _03_OOP_Defining_Classes_Exercise_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP_Defining_Classes_Excercise_1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Make of the Car");
            string make = Console.ReadLine();

            Console.WriteLine("Enter the model name of the car");
            string model = Console.ReadLine();

            Console.WriteLine("Enter the year of the car");
            string yearAsString = Console.ReadLine();
            int year = Int32.Parse(yearAsString);
            

            Car car = new Car(make, model, year);

            Console.WriteLine($"{car.CarMake} {car.CarModel} {car.CarYear}");
        }

    }
}
