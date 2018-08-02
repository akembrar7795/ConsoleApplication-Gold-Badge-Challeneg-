using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ClaimRepository
    {
        public List<Claim> claimRepo = new List<Claim>();

        // methods
        public void ShowMenu()
        {
            Console.WriteLine($"1. See all claims \n" + "2. Take care of next claim\n" + "3. Enter a new claim");
        }

        public void AddList(Claim menu)
        {
            claimRepo.Add(menu);
        }
        public List<Claim> GetItems()
        {
            return claimRepo;
        }
        public void RemoveItem(Claim item)
        {
            claimRepo.Remove(item);
        }
    }
}
