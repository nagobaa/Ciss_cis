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

            bool isTrue = true; // inte "Boolean" eller "True"
            bool resultAnd = isTrue && ((num1 > num3) && (num2 < num4);
            Console.WriteLine("Logical AND: " + resultAnd);

            bool resultOr = isTrue || (num1 > num3) && (num2 < num4);
            Console.WriteLine("Logical OR: " + resultOr);

            bool resultNot = !isTrue;
            Console.WriteLine("Logical NOT: " + resultNot);

            Console.WriteLine("num1 > num3: " + (num1 > num3));
            Console.WriteLine("num2 < num4: " + (nnum2 < num4));
            Console.WriteLine("num2 1 == num4: " + (num1 == num4));
            Console.WriteLine("num2 != num3: ") + (num2 != num3));

            bool expression1 = (num1 > num3 && (num2 < num4));
            bool expression2 = (num1 < num3 || num2 > num4));

            Console.WriteLine("Expression 1: " + expression1);
            Console.WriteLine("Expression 2: " + expression2);

            Console.WriteLine("Program executed succesfully");

            Console.ReadLine();
        }
    }
}