using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Claim claim = new Claim(1, "car", "accident on 465", 400, DateTime.Parse("4 / 25 / 18"), DateTime.Parse("4/27/18"),true);
            Claim claim2 = new Claim(2, "house", "House Fire in Kitchen", 4000.00, DateTime.Parse("4 / 26 / 18"), DateTime.Parse("4/28/18"), true);
            Claim claim3 = new Claim(3, "theft", "Stolen Pancakes", 4.00, DateTime.Parse("4 / 27 / 18"), DateTime.Parse("6/01/18"), false);

            ClaimRepository claimRepo = new ClaimRepository();
            claimRepo.AddList(claim);
            claimRepo.AddList(claim2);
            claimRepo.AddList(claim3);

            string Response = "Null";
            while (Response != "4")
            {

                List<Claim> list = claimRepo.GetItems();

                Console.WriteLine("Would you like to see our menu (y/n)");

                string reply1 = Console.ReadLine();


                ClaimRepository claimList = new ClaimRepository();

                if (reply1 == "y")
                {
                    claimList.ShowMenu();
                    Console.WriteLine("Choose a menu item listed above");
                    int itemNumber = int.Parse(Console.ReadLine());

                    if (itemNumber == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("ClaimId\t" + " " +"ClaimType\t" + " " + "Description\t" + " " + "ClaimAmount\t"+ " " +"IncidentDate\t" + " " + "ClaimDate\t" + " " + "IsValid\t");

                        foreach (Claim item in list)
                            
                            Console.WriteLine($" {item.ClaimId}\t" + " " + $" {item.ClaimType}\t" + " " + $"{item.Description}\t" + " " + $"{item.ClaimAmmount}\t" + " " + $"{item.DateOfIncident}\t" + " " + $"{item.DateOfClaim}\t" + " " + $"{item.IsValid}\t");
                    }
                    else if (itemNumber == 2)
                    {
                        Console.Clear();
                        Console.WriteLine($" ClaimID: {claim.ClaimId}\n" +
                            $"ClaimType: {claim.ClaimType}\n" +
                            $"Description: {claim.Description}\n" +
                            $"ClaimAmmount: {claim.ClaimAmmount}\n" +
                            $"DateofIncident: {claim.DateOfIncident}\n" +
                            $"DateofClaim: {claim.DateOfClaim}\n" +
                            $"IsValid: {claim.IsValid}");

                        Console.WriteLine("Do you want to deal with this claim now(y/n)");
                        string reply2 = Console.ReadLine();
                        if (reply2 == "y")
                        {
                            claimRepo.RemoveItem(claim);
                        }
                        else if (reply2 == "n")
                        {
                            Console.Clear();
                            claimList.ShowMenu();
                        }
                    }

                    else if (itemNumber == 3)
                    {
                        Console.WriteLine("Enter a claim ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the claim type: ");
                        string claimType = Console.ReadLine();
                        Console.WriteLine("Enter a claim Description: ");
                        string claimDescription = Console.ReadLine();
                        Console.WriteLine("Amount: ");
                        double amount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Date of Incident");
                        DateTime incident = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Date of claim");
                        DateTime claimDate = DateTime.Parse(Console.ReadLine());
                        TimeSpan span = new TimeSpan(30, 0, 0, 0);
                        if(claimDate - incident <= span)
                        {
                            Console.WriteLine("This claim is Valid");

                        }

                        else
                        {
                            Console.WriteLine("This claim is not Vlid");
                        }

                        


                    }
                }

            }
            
            
        }
    }
}
