using System; // detta ska med
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicError3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++) // inte <=
            {
                sum += numbers[i];
            }

            Console.WriteLine("Sum of numbers: " + sum);
            Console.ReadLine();
        }
    }
}
