using System;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            // användarninmatning
            Console.Write("Please enter a number: ");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);

            //granskning av jämt eller udda
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even.");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd.");
            }

        Console.ReadKey();

        }
    }
}
