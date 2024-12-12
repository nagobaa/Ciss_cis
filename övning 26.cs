using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift26
{
    class Calculator
    {
        public double Divide(int numerator, int denominator) // numerator = täljare, denominator = nämnare
        {
            try
            {
                return numerator / denominator;
            }
            catch
            {
                Console.WriteLine("DivideByZeroException");
                return 0.0;
            }
        }

        public int ParseInput(string x)
        {
            try
            {
                int y = Convert.ToInt32(x);
                return y;
            }
            catch
            {
                Console.WriteLine("FormatException");
                return -1;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //ett fall av klassen "Calculator" 
            Calculator calculator = new Calculator();

            //användarinmatning
            Console.WriteLine("Please enter the first integer for division: ");
            string numeratorInput = Console.ReadLine();
            Console.WriteLine("Please enter the second integer for division: ");
            string denominatorInput = Console.ReadLine();

            //försök av byte till heltal av 32 bit
            calculator.ParseInput(numeratorInput); // "calculator." ska vara med
            calculator.ParseInput(denominatorInput); // "calculator." ska vara med

            //kallelse på "Divide"-metoden
        }
    }
}



