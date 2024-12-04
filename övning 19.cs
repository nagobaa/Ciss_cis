using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 1, 2, 3, 4 };

            int newSum = SumOfNumbers(array); // detta behövs innan återlämningsvärdet används

            if (newSum > -1)
                Console.WriteLine($"The total is: {newSum}");
            else
                Console.WriteLine("Cannot add up to an empty array");
            
            int length = array.Length;
            Console.WriteLine($"The length of the array is {length}.");
        }

        static int SumOfNumbers(int[] x) // inte bara (x)
        {
            // summan av fältet ska räknas här
            int newSum = x.Sum();
            return newSum;
        }
    }
}


