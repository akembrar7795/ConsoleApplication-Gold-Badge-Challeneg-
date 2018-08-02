using _03_OOP_Defining_Classes_Exercise_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP_Defining_Classes_Excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your firstname");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your lastname");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your IDnumber");
            int iD = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your number of years with company");
            int numberOfYears = int.Parse(Console.ReadLine());

            if (numberOfYears >=1 && numberOfYears < 5)
            {
                Console.WriteLine("Thanks" + firstName + "for being a member with us");
            }
            else if( numberOfYears >= 5)
            {
                Console.WriteLine("Thanks " + firstName + " for being a Gold member with us");
            }
            
            Customer customer = new Customer(firstName, lastName, iD, numberOfYears);

            Console.WriteLine($"{customer.FirstName} {customer.LastName} {customer.IDNumber} {customer.NumberOfYearsUsingTomado}");

            Console.ReadLine();
        }
    }
}
