using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    public class Phone
    {
       
        //Properties
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Cost { get; set; }

        //Construct
        public Phone(string maker, string model, int cost)
        {
            Maker = maker;
            Model = model;
            Cost = cost;
        }

    }
}
