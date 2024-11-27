using System;
using System.Collections.Generic; // List <T>

namespace test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 7;
            int length = 5;

            //"array" kan inte tillsättas värden, likt Python [] (?), eller
            //"tuple" (det har dock bara två värden)? 
            //string [] lista = new string [] { "1", "2", "3", "4", "5" };
            //listor kan tillsättas nya värden
            List<string> lista = new List<string> { "1", "2", "3", "4", "5" };

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{num} * {lista[i]}");
            }
            lista.Add("loop couter x num");
            Console.WriteLine($"Multiplikation number for {num}:");

            Console.ReadKey();
        }
    }
}