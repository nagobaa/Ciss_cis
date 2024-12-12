using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift27
{
    class MathOperations
    {
        public string Addition (int x, int y) // inte "int", far enligt returtyp
        {
            return $"Addition result: {x} + {y} = {x + y}";
        }
        public string Substraction (int x, int y)
        {
            return $"Substraction result: {x} - {y} = {x - y}";
        }
        public string Multiplication (int x, int y)
        {
            return $"Multiplication result: {x} * {y} = {x * y}";
        }
        public string Division (int x, int y)
        {
            try
            {
                return $"Division result: {x} / {y} = {x / y}";
            }
            catch (DivideByZeroException)
            {
                return "\nIf division by zero is attempted:\nCannot divide by zero.";
            }
        }
        public string Power (int x, int y)
        {
            return $"Power result: {x} ** {y} = {Math.Pow(x, y)}"; // "x ** y" fungerar inte i C#
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();

            Console.WriteLine("Example Input and Output:");
            Console.WriteLine("\nInput:");

            //användarinmatning
            Console.WriteLine("Enter the first number: ");
            string number1Input = Console.ReadLine();
            Console.WriteLine("\nEnter the second number: ");
            string number2Input = Console.ReadLine();

            Console.WriteLine("\nOutput:");

            //ändring av datatyp
            int number1 = Convert.ToInt32(number1Input);
            int number2 = Convert.ToInt32(number2Input);

            //kallelse och utskrift på funktioner
            Console.WriteLine(mathOperations.Addition(number1, number2));
            Console.WriteLine(mathOperations.Substraction(number1, number2));
            Console.WriteLine(mathOperations.Multiplication(number1, number2));
            Console.WriteLine(mathOperations.Division(number1, number2));
            Console.WriteLine(mathOperations.Power(number1, number2));
        }
    }
}
