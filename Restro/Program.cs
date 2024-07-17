// See https://aka.ms/new-console-template for more information

using Restro;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FoodItems :");
        Console.WriteLine("Fries :  49Rs (American fries)");
        Console.WriteLine("Momos : 109Rs (spicy wheat momos)");

        Console.WriteLine("\nDrinkItems :");
        Console.WriteLine("Coke  :  99Rs (Coca-Cola)");
        Console.WriteLine("Coffee:  59Rs (Brewed from roasted coffee beans)");



        MenuManager menuManager = new MenuManager();

        menuManager.AddMenuItem(new FoodItem("Momos", 109));
        menuManager.AddMenuItem(new DrinkItem("Coke", 99));
        menuManager.AddMenuItem(new FoodItem("Fries", 49));


        Console.WriteLine("\nInitial menu items:");
        foreach (var item in menuManager.GetMenuItems())
        {
            Console.WriteLine($"{item.Name} - {item.Price:.00}Rs");
        }
        foreach (var item in menuManager.GetMenuItems())
        {
            if (item.Name.Contains("Fries"))                  
            {
                menuManager.RemoveMenuItem(item);
                Console.WriteLine("\nMayank i think you don't like "+ item.Name );
                break;
            }
        }


        Console.WriteLine("\nMenu items after removal:");
        foreach (var item in menuManager.GetMenuItems())
        {
            Console.WriteLine($"{item.Name} - {item.Price:.00}Rs");
        }

        
        List<IMenuItem> orderItems = new List<IMenuItem>
        {
            new FoodItem("Momos", 109),
            new DrinkItem("Coke", 99 )
        };

        OrderManager orderManager = new OrderManager((MenuManager)menuManager);
        decimal totalCost = orderManager.CalculateTotalCostOfOrder(orderItems);
        Console.WriteLine($"Total cost of order: {totalCost:.00}Rs");
    }
}