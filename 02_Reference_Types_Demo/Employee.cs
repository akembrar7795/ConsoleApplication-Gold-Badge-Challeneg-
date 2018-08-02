using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reference_Types_Demo
{
    public class Employee
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfYearsExperience { get; set; }
        public int age { get; set; }
        public int EmployeeID { get; set; }

        //Methods
        public string GetFullName()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }

    }
}
