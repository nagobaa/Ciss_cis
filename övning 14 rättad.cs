using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift14korrekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;

            // definition av fält(array), värden saknas ännu
            int[] array = new int[length]; // längden på fältet är "length"

            // insättning av värden till fältet
            for (int i = 0; i < length; i++)
            {
                array[i] = num * (i + 1);
            }

            // ChatGPT
            for (int i = 0;i < length; i++)
                Console.Write(array[i] + " ");
        }
    }
}
