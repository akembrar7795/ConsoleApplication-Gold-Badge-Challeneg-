using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Claim
    {
        //constructor
        public Claim(int claimid, string claimtype, string description, double claimammount, DateTime dateofincident, DateTime dateofclaim, bool isvalid)
        {
            ClaimId = claimid;
            ClaimType = claimtype;
            Description = description;
            ClaimAmmount = claimammount;
            DateOfIncident = dateofincident;
            DateOfClaim = dateofclaim;
            IsValid = isvalid;
        }

        public int ClaimId { get; set; }
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public double ClaimAmmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

       
    }
}
