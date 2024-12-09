using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace uppgift24
{
    class Product
    {
        public string Name { get; set; } // stor begynnelsebokstav
        public double Price { get; set; } // stor begynnelsebokstav
        private int Stock { get; set; } // denna är av någon anledning privat

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        public void SetName(string x)
        {
            Name = x;
        }
        public string ReceiveName()
        {
            return Name;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }
        public double ReceivePrice()
        {
            return Price;
        }
        public void SetQuantity(int quantity)
        {
            Stock = quantity;
        }
        public int ReceiveQuantity() 
        {
            return Stock;
        }
        public void ReturnDetails()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Stock: {Stock}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Phone", 599, 5);
            Console.WriteLine("Initial product details:");
            product1.ReturnDetails();
            Product product2 = new Product("Laptop", 999.9, 10);
            Console.WriteLine("updated product details:");
            product2.ReturnDetails();
        }
    }
}


