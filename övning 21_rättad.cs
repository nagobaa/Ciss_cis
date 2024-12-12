using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicError2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 34;

            if (age > 50) // byter plats med (age > 50)
            {
                Console.WriteLine("Over 50");
            }
            else if (age > 30)
            {
                Console.WriteLine("Over 30");
            }
            else if (age > 18) // byter plats med (age > 18)
            {
                Console.WriteLine("Over 18");
            }
            else
            {
                Console.WriteLine("18 or under");
            }
            Console.ReadLine();
        }
    }
}