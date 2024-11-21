using System;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age as a string variable. ");
            string nameInput = Console.ReadLine();
            int age = Convert.ToInt32(nameInput);

            int LegalAge = 18;

            if (age >= LegalAge)
            {
                Console.WriteLine("\nYou are an adult.");
            }
            else
            {
                Console.WriteLine("\nYou are under the legal age.");
            }

            int counter = 1;
            while (counter <= 5)
            {
                Console.WriteLine("The value of the integer 'counter' is: " + counter);

                switch (counter)
                {
                    case 1:
                        Console.WriteLine("1");
                        break;

                    case 2:
                        Console.WriteLine("2");
                        break;

                    case 3:
                        Console.WriteLine("3");
                        break;

                    case 4:
                        Console.WriteLine("4");
                        break;

                    case 5:
                        Console.WriteLine("5");
                        break;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
                counter += 1;
            }

            var name = "John"; // istållet för att skriva ut direkt datatypen
            Console.WriteLine("\nWelcome" + " " + name);
            Console.WriteLine("\nThe results for the loop and the switch statement are as follows: ");
            {
                int counter2 = 1;
                while (counter2 <= 5)
                {
                    Console.WriteLine("The value of the integer 'counter' is: " + counter2);

                    switch (counter2)
                    {
                        case 1:
                            Console.WriteLine("1");
                            break;

                        case 2:
                            Console.WriteLine("2");
                            break;

                        case 3:
                            Console.WriteLine("3");
                            break;

                        case 4:
                            Console.WriteLine("4");
                            break;

                        case 5:
                            Console.WriteLine("5");
                            break;
                        default:
                            Console.WriteLine("Invalid number");
                            break;
                    }
                    counter2 += 1;
                }
            }

            Console.ReadKey();
        }
    }
}


