using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the maker of the device");
            string maker = Console.ReadLine();

            Console.WriteLine("Enter the model of the device");
            string model = Console.ReadLine();

            Console.WriteLine("Enter the value of your device");
            int cost = int.Parse(Console.ReadLine());

            Phone phone = new Phone(maker, model, cost);

            Console.WriteLine("You entered the following: ");
            Console.WriteLine($"Maker: {phone.Maker}");
            Console.WriteLine($"Model: {phone.Model}");
            Console.WriteLine($"Cost: {phone.Cost}");

            //Another method to break lines
            //Console.WriteLine($"You entered the following: \r\n +" +
            //    $"Maker: {phone.Maker}\r\n" +
            //    $"Model: {phone.Model}\r\n" +
            //    $"Cost: {phone.Cost}");
                
            Console.ReadLine();
        }
    }
}
