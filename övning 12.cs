using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // inmatning av lösenord
                Console.Write("Please enter the first password: ");
                string losenord1 = Console.ReadLine();

                Console.Write ("Please enter the second password: ");
                string losenord2 = Console.ReadLine();

                // granskning ifall listan är tom
                if (string.IsNullOrEmpty(losenord1) || string.IsNullOrEmpty(losenord2))
                {
                    Console.WriteLine("One or both of the passwords is/are empty.");
                    Console.WriteLine("Please enter a password");
                    continue;
                }
                else
                {
                    // granskning ifall någotdera av lösenorden är för korta
                    if (losenord1.Length < 6 || losenord2.Length < 6)
                    {
                        Console.WriteLine("One or both of the passwords is/are shorter than 6 characters.");
                        Console.WriteLine("Please enter a password");
                        continue;
                    }
                    else
                    {
                        // granskning ifall lösenorden är samma
                        if (losenord1 == losenord2)
                        {
                            Console.WriteLine("Passwords match");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match");
                            continue;
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}









