using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP_Defining_Classes_Exercise_3
{
    public class Developer

    {
        //Field
        public List<Developer> _developerList = new List<Developer>();

        //-Constructor
        public Developer(int id, string lastname, bool haspluralsightaccount)
        {
            ID = id;
            LastName = lastname;
            HasPluralSightAccount = haspluralsightaccount;
        }

        //-- Properties
        public int ID { get; set; }
        public string LastName { get; set; }
        public bool HasPluralSightAccount { get; set; }

        //-- Method
        public void AddDeveloperToList(Developer developer)
        {
            _developerList.Add(developer);
        }


    }



}
