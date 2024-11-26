using System;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            // värden till variabler
            int num1 = 1;
            int num2 = 3;
            int num3 = 2;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;

            //summan av num1 och num2
            int summa = num1 + num2;
            Console.WriteLine($"{num1} + {num2} is {summa}.");

            //produkten av num3 och num4
            int produkt = num3 * num4;
            Console.WriteLine($"{num3} * {num4} is {produkt}.");

            //resten av num5 delat med num 6
            int rest = num5 % num6;
            Console.WriteLine($"{num5} % {num6} is {rest}.");

            //prefix ++
            Console.WriteLine($"\nnum1 is {num1}.");
            Console.WriteLine("++num1 is " + (++num1) + ".");

            //prefix --
            Console.WriteLine($"\nnum2 is {num2}.");
            Console.WriteLine("--num2 is " + (--num2) + ".");

            //postfix ++            
            Console.WriteLine($"\nnum3 is {num3}.");
            Console.WriteLine("num3++ is " + (num3++) + ".");
            Console.WriteLine($"num3 is {num3}.");

            //postfix --
            Console.WriteLine($"\nnum4 is {num4}.");
            Console.WriteLine("num4-- is " + (num4--) + ".");
            Console.WriteLine($"num4-- is {num4}.");

            // num 1 =  num5 += 2;
            Console.WriteLine($"\nnum5 is {num5}.");
            num5 -= 2;
            Console.WriteLine($"num5 -= 2 is {num5}.");

            // num 6 =  num6 - 2;
            Console.WriteLine($"\nnum6 is {num6}.");
            num6 -= 2;
            Console.WriteLine($"num6 -= 2 is {num6}.");

            // num 1 =  num1 * 2;
            Console.WriteLine($"\nnum1 is {num1}.");
            num1 *= 2;
            Console.WriteLine($"num1 *= 2 is {num1}.");

            // num 2 =  num2 / 2;
            Console.WriteLine($"\nnum2 is {num2}.");
            num2 /= 2;
            Console.WriteLine($"num2 /= 2 is {num2}.");

            // num 3 =  num3 % 2;
            Console.WriteLine($"\nnum3 is {num3}.");
            num3 %= 2;
            Console.WriteLine($"num3 %= 2 is {num3}.");

            Console.ReadKey();
        }
    }
}