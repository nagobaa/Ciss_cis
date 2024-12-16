using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_24_rättad
{
    class Product
    {
        private string Name { get; set; } // indrag av rad
        private double Price { get; set; } // indrag av rad
        private int Stock { get; set; } // indrag av rad
        public Product(string name, double price, int stock) // inga "public"/"private" hit
        {
            Name = name; // eller this.name = name;
            Price = price; // eller this.price = price;
            Stock = stock; // eller this.stock = stock;
        }
        public void SetName(string x) // inget "private"/"public" vid parametern
        {
            Name = x;
        }
        public string ReceiveName()
        {
            return Name;
        }
        public void SetPrice(double x) // inget "private"/"public" vid parametern
        {
            Price = x;
        }
        public double ReceivePrice()
        {
            return Price;
        }
        public void SetQuantity(int x) // inget "private"/"public" vid parametern
        {
            Stock = x;
        }
        public int ReceiveQuantity()
        {
            return Stock;
        }
        public void ReturnDetails()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Stock: {Stock}"); // inte {name}, {price} etc.
        }
    }
    class Program // inte internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Phone", 599, 5);
            Console.WriteLine("Initial product details:");
            product.ReturnDetails();
            Product product2 = new Product("Laptop", 999.9, 10);
            Console.WriteLine("Updated product details:");
            product2.ReturnDetails();
        }
    }
}
