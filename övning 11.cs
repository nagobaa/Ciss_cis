using System;
using System.Linq;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            // användarninamtning
            Console.Write("Please write a message. ");
            string meddelande = Console.ReadLine();

            // utskrift av kod
            string meddelande_baklanges = new string(meddelande.Reverse().ToArray());

            Console.WriteLine(meddelande_baklanges);



            //utskrift ett tecken i gången
            for (int i = 0; i < meddelande.Length; i++)
            {
                Console.WriteLine(meddelande[i]);
            }

            //utskrift ett tecken i gången baklänges
            for (int i = 0; i < meddelande_baklanges.Length; i++)
            {
                Console.WriteLine(meddelande_baklanges[i]);
            }
            Console.ReadKey();
        }
    }
}