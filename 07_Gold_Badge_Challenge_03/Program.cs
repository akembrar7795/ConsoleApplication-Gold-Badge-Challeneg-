using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Gold_Badge_Challenge_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Outing outing1 = new Outing("golf", 10, DateTime.Parse("07/30/2018"), 20.00, 200.00);
            Outing outing2 = new Outing("Bowling", 9, DateTime.Parse("07/30/2018"), 10.00, 90.00);
            Outing outing3 = new Outing("AmusementPark", 12, DateTime.Parse("07/30/2018"), 10.00, 120.00);
            Outing outing4 = new Outing("Concert", 8, DateTime.Parse("07/30/2018"), 20.00, 160.00);
            Outing outing5 = new Outing("golf", 10, DateTime.Parse("07/30/2018"), 20.00, 200.00);
            Outing outing6 = new Outing("golf", 10, DateTime.Parse("07/30/2018"), 20.00, 200.00);

            OutingsRepository copyOfRepo = new OutingsRepository();
            copyOfRepo.addOutingToList(outing1);
            copyOfRepo.addOutingToList(outing2);
            copyOfRepo.addOutingToList(outing3);
            copyOfRepo.addOutingToList(outing4);
            copyOfRepo.addOutingToList(outing5);
            copyOfRepo.addOutingToList(outing6);

            List<Outing> myNewList = copyOfRepo.getList();

            string response = "null";
            while(response != "5")
            {

                Console.WriteLine("Would You Like To See Our Menu: (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("1.) Display a list of all outings");
                    Console.WriteLine("2.) Add individual outings to a list");
                    Console.WriteLine("3.) Calculations");
                    int selectedNumber = int.Parse(Console.ReadLine());

                    if (selectedNumber == 1)
                    {
                        Console.WriteLine("Event Type/t" + "PeopleAttended\t" + "Date\t" + "PersonCost\t" + "EventCost\t");
                        foreach (Outing eachOuting in myNewList)
                        {
                            Console.WriteLine($" {eachOuting.EventType}\t" + $"{eachOuting.NumberOfPeopleAttended}\t" + $"{eachOuting.Date}\t" + $"{eachOuting.CostPerPerson}\t" + $"{eachOuting.CostForEvent}\t");
                        }
                    }

                    if (selectedNumber == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the Event Type: ");
                        string eventType = Console.ReadLine();
                        Console.WriteLine("Enter the Number of People attended:");
                        int numberOfPeopleAttended = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Date: ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the cost per person:");
                        double costPerPerson = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the cost for event: ");
                        double costForEvent = double.Parse(Console.ReadLine());

                        Outing outingObject = new Outing(eventType, numberOfPeopleAttended, date, costPerPerson, costForEvent);
                        copyOfRepo.addOutingToList(outingObject);
                        foreach (Outing item in myNewList)
                        {
                            Console.WriteLine($"{item.EventType} " + $"{item.NumberOfPeopleAttended} " + $"{item.Date} " + $"{item.CostPerPerson} " + $"{item.CostForEvent} ");
                        }

                    }


                    if (selectedNumber == 3)
                    {
                        Console.Clear();
                        double golfTotal = 0;
                        double bowlingTotal = 0;
                        double amusementParkTotal = 0;
                        double concertTotal = 0;
                        foreach (Outing eachOuting in myNewList)
                        {
                            if (eachOuting.EventType == "golf")
                            {
                                golfTotal = golfTotal + eachOuting.CostForEvent;
                            }
                            else if (eachOuting.EventType == "Bowling")
                            {
                                bowlingTotal = bowlingTotal + eachOuting.CostForEvent;
                            }
                            else if (eachOuting.EventType == "Amusement Park")
                            {
                                amusementParkTotal = amusementParkTotal + eachOuting.CostForEvent;
                            }
                            else if (eachOuting.EventType == "Concert")
                            {
                                concertTotal = concertTotal + eachOuting.CostForEvent;
                            }
                        }
                        double total = golfTotal + bowlingTotal + amusementParkTotal + concertTotal;
                        Console.WriteLine("Total for all outings: " + (total) + "\n Golf Event Total: " + golfTotal + ", Bowling Event Total: " + bowlingTotal + " Amusement Park Totatl is: " + amusementParkTotal + " Concert event Total is: " + concertTotal);
                    }

                }


            }
            

            

        }
    }
}
