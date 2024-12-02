using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uppgift17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bibliotek, ett bibliotek utan nyckel-värde par behöver inte {}
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            bool running = true;

            // running == true
            while (running)
            {
                // utskrift av meny
                Console.WriteLine("1. Add Subject");
                Console.WriteLine("2. Remove Subject");
                Console.WriteLine("3. Show all");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option between 1 and 4 ");
                string inputUser = Console.ReadLine();

                // inmatning av nyckel-värde par
                if (inputUser == "1")
                {
                    Console.Write("Enter the name if the new subject: ");
                    string subject = Console.ReadLine();
                    //dictionary.add(subject); inte här
                    Console.Write("Teachers name: ");
                    string teacher = Console.ReadLine();
                    //dictionary.Add(teacher); // inte här
                    Console.WriteLine("Subject and teacher added.");

                    //Dictionary.add(subject); och Dictionary.Add(teacher); hit nedan
                    dictionary.Add(subject, teacher); // detta tillägger ämne och lärare till ordboken // inte ".add"
                }
                // raderan av nyckel-värde par
                else if (inputUser == "2")
                {
                    Console.WriteLine("Please enter the entry key to delete: ");
                    string userInput = Console.ReadLine();
                    
                    if (dictionary.ContainsKey(userInput)) // namnet på ordbok.ContainsKey(variabelnamn)
                    {
                        dictionary.Remove(userInput);
                    }
                    else
                    {
                        Console.WriteLine("The key entry was not found");
                    }
                }
                // utskrift av allting
                else if (inputUser == "3")
                {
                    foreach (var x in dictionary) // var är vilken helst som datatyp, behändigt i detta sammanhang
                        Console.WriteLine($"{x.Key}: Teacher {x.Value}"); // "Key" och "Value" inte "key" och "value"
                }
                // avslutning av program
                else if (inputUser == "4")
                {
                    running = false; // datatypen bool (boolean) har redan en gång definierats till variabeln running, det blir fel om datatypen definieras igen 
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }

                Console.ReadKey();
            }            
        }
    }
}
