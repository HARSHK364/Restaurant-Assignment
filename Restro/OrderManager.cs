using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restro
{
    public class OrderManager
    {
        MenuManager menuManager;

        public OrderManager(MenuManager menuManager)
        {
            this.menuManager = menuManager;
        }

        public int CalculateTotalCostOfOrder(List<IMenuItem> orderItems)
        {
            int totalCost = 0;
            foreach (var item in orderItems)
            {
                totalCost += item.Price;
            }
            return totalCost;
        }
    }

}
