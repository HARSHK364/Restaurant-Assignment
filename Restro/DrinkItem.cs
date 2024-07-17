using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restro
{
    public class DrinkItem : IMenuItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
  

        public DrinkItem(string name, int price)
        {
            Name = name;
            Price = price;
           
         
        }

     
    }

}
