using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift25_korrekt
{
    public class Inventory
    {
        // "private list to store the names of all items
        private List<string> items = new List<string>();

        // "Private dictionary to store item details"
        // "Each key is the item's name, and the value is a tuple containing the price and quantity
        private Dictionary<string, (double price, int stock)> itemDetails = new Dictionary<string, (double, int)>();
        
        // "method to add a new item to the inventory"
        public void AddItem(string name, double price, int stock)
        {
            items.Add(name);
            itemDetails[name] = (price, stock);
        }
        // "Method to remove an item from the inventory"
        public void RemoveItem(string name)
        {
            // "attempt to remove the item from the list of items"
            if (items.Remove(name))
            {
                itemDetails.Remove(name);
                Console.WriteLine($"{name} has been removed from the inventory.");
            }
            else
            {
                // "if the item does not exist notifies the user"
                Console.WriteLine($"{name} does not exist in the inventory");
            }
        }
        // "method to update the stock of a specific item
        public void UpdateStock(string name, int newStock)
        {
            // "Check if the item exists in the directory"
            if(itemDetails.TryGetValue(name, out var details))
            {
                // "update the stock value while keeping the price unchanged"
                itemDetails[name] = (details.price, newStock);
                Console.WriteLine($"Stock of {name} updated to {newStock}.");
            }
            else
            {
                // "if the item does not exist notifies the user"
                Console.WriteLine($"{name} is not in inventory currently");
            }
        }

        // "method to retrieve and print all items along their details"
        public void PrintAllItems()
        {
            Console.WriteLine("Current Inventory");

            // "loop through all item and print them out"
            foreach (var item in items)
            {
                var details = itemDetails[item];
                Console.WriteLine($"Product: {item}, Price: {details.price}, Stock: {details.stock}");
            }
        }

        // "method to find and print the most expensive item in the inventory"
        public void PrintMostExpensiveItem()
        {
            string expensiveItem = null; // "Variable to store the name of the most expensive item"
            double highestPrice = 0; // "Variable to store the highest price found

            // "loop through all item to find the one with the highest value"
            foreach (var item in items)
            {
                var details = itemDetails[item];
                if(details.price > highestPrice)
                {
                    highestPrice = details.price;
                    expensiveItem = item;
                }
            }
            // "if an expenisive item was found, the details will be printed"
            if (expensiveItem != null)
            {
                Console.WriteLine($"The most expensive item: {expensiveItem}, Price: {highestPrice}");
            }
            else
            {
                // "if no items exist in the inventory, notification to the user"
                Console.WriteLine("No items in inventory");
            }
        }
        public void PrintTotaltInventoryValue()
        {
            double totalValue = 0; // "Variable to accumulate the total inventory value

            // "Loop through all items and calculate their total value (Price * stock)"
            foreach (var item in items)
            {
                var details = itemDetails[item];
                totalValue += details.price * details.stock;
            }
            // "print the total value of the inventory"
            Console.WriteLine($"Total Inventory Value: {totalValue}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // "Create an instance of the inventory Class"
            Inventory inventory = new Inventory();

            // "Add products to the inventory"
            inventory.AddItem("Laptop", 1200.50, 7);
            inventory.AddItem("Smartphone", 799.99, 12);
            inventory.AddItem("Tablet", 399.99, 15);

            inventory.PrintAllItems();

            inventory.UpdateStock("Laptop", 5);

            inventory.RemoveItem("Tablet");

            inventory.PrintMostExpensiveItem();

            inventory.PrintTotaltInventoryValue();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
