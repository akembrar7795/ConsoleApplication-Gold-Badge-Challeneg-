using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Gold_Badge_Challenge_01
{
     public class MenuRepository
    {
        public List<Menu> MenuRepo = new List<Menu>();

        //methods
        public void AddMenu(Menu item)
        {
            MenuRepo.Add(item);

        }
        public List<Menu> GetItems()
        {
            return MenuRepo;
        }
        public void DeleteItem(Menu item)
        {
            MenuRepo.Remove(item);
        }
        public void AddItems(Menu items)
        {
            MenuRepo.Add(items);
        }
    }
}
