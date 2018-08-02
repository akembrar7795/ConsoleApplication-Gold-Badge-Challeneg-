using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Gold_Badge_Challenge_03
{
    public class OutingsRepository
    {
        public List<Outing> AllLists = new List<Outing>();

        //methods
        public void addOutingToList(Outing singleOuting)
        {
            AllLists.Add(singleOuting);
        }

        public void removeOutingFromList(Outing singleOuting)
        {
            AllLists.Remove(singleOuting);
        }

        public List<Outing> getList()
        {
            return AllLists;
        }
        
    }
}
