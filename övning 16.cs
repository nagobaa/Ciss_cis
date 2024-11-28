using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inteLista = new int[] { 45, 12, 78, 34, 89, 23 };

            Console.WriteLine(string.Join(", ", (inteLista)));

            // det minsta värdet till det största
            Array.Sort(inteLista); // inte "array" utan "Array"
            Console.WriteLine(string.Join(", ", (inteLista)));

            // det största värdet till det minsta
            Array.Reverse(inteLista); // inte "array" utan "Array"
            Console.WriteLine(string.Join(", ", (inteLista)));

            //fält (array) till lista
            List<int> lista = new List<int>(inteLista);

            // bortaggning av värde
            lista.Remove(78);

            //lista till fält(array)
            int[] inteLista2 = lista.ToArray();

            Console.WriteLine(string.Join(", ", (inteLista2)));

            // sökning av ett värde på en "intelista"
            int variabel = Array.IndexOf(inteLista2, 34);
            if (variabel != -1) // -1 är att elementet inte finns
            {
                Console.WriteLine("The value 34 exists.");
            }
            else
            {
                Console.WriteLine("The value 34 is nonexistant.");
            }

            Console.ReadKey(); 
        }
    }
}


 




