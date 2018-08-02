using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Gold_Badge_Challenge_03
{
    public class Outing
    {
        public Outing( string eventType, int numberOfPeopleAttended, DateTime date, double costPerPerson, double costForEvent)
        {
            EventType = eventType;
            NumberOfPeopleAttended = numberOfPeopleAttended;
            Date = date;
            CostPerPerson = costPerPerson;
            CostForEvent = costForEvent;
        }

        public string EventType { get; set; }
        public int NumberOfPeopleAttended { get; set; }
        public DateTime Date { get; set; }
        public double CostPerPerson { get; set; }
        public double CostForEvent { get; set; }

        
    }
}
