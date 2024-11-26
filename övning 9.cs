using System;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = num1;

            bool isTrue = true; // inte "Boolenan" eller "True"

            if ((isTrue == true) && ((num1 > num3) && (num2 < num4)))
            {
                Console.WriteLine("(isTrue == true) && ((num1 > num3) && (num2 < num4)) is true.");
            }
            else
            {
                Console.WriteLine("(isTrue == true) && ((num1 > num3) && (num2 < num4)) is false.");
            }

            if ((isTrue == true) || ((num1 < num3) || (num2 > num4)))
            {
                Console.WriteLine("(isTrue = true) || ((num1 < num3) || (num2 > num4)) is true");
            }
            else
            {
                Console.WriteLine("(isTrue == true) || ((num1 < num3) || (num2 > num4)) is false");
            }

            if (!isTrue == true)
            {
                Console.WriteLine("Bool isTrue is not 'false'.");
            }
            else
            {
                Console.WriteLine("Bool isTrue is not 'true'");
            }

            Console.ReadKey();
        }
    }
}