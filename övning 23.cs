using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////version 1
            //Console.WriteLine("Version 1");
            ////användarinmatning
            //Console.Write("Please give a value to a string variabel: ");

            //try
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Conversion succeeded: {num}");
            //}
            //// bokstäver
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please do not enter letters.");
            //}
            //// för stora eller små värden
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Please input a value smaller than 2 billions");
            //}
            //// övriga fel
            //catch (Exception e)
            //{
            //    // detta visar ett allmänt felmeddelande
            //    Console.WriteLine($"Error: {e.Message}");
            //}

            //version 2
            Console.WriteLine("Version 2");

            // användarinmatning
            Console.Write("Please give a value to a string variabel: ");
            // variabeln definieras
            string variabel = Console.ReadLine();

            /*Det är bättre att ha alltid relaterat till en viss uppgift
            inom en funktion istället för att ha det skrivet in i 
            huvudfunktionen */

            //funktionen påkallas
            if (function(variabel, out int x))
            {
                Console.WriteLine("$The conversion was successful: {x}");
            }
            else
            {
                Console.WriteLine("$The conversion was unsuccessful");
            }

            // funktion
            static bool function(string x, out y)
            {
                try
                {
                    int y = Convert.ToInt32(Console.ReadLine(x));
                    return true;
                }
                // bokstäver
                catch (FormatException)
                {
                    Console.WriteLine("Please do not enter letters.");
                }
                // för stora eller små bokstäver
                catch (OverflowException)
                {
                    Console.WriteLine("Please input a value smaller than 2 billions");
                }
                // övriga fel
                catch (Exception e)
                {
                    // detta visar ett allmänt felmeddelande
                    Console.WriteLine($"Error: {e.Message}");
                }
                y = 0;
                return false;
            }
        }
    }
}
