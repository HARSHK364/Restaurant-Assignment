using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restro
{
    public class MenuManager
    {
       List<IMenuItem> menuItems;

        public MenuManager()
        {
            menuItems = new List<IMenuItem>();
        }

        public void AddMenuItem(IMenuItem item)
        {
            menuItems.Add(item);
        }

        public void RemoveMenuItem(IMenuItem item)
        {
            menuItems.Remove(item);
        }

        public List<IMenuItem> GetMenuItems()
        {
            return menuItems;
        }
    }
}
