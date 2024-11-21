using System;

namespace text
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What is your age? ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if (age < 18)
            {
                Console.WriteLine("Not eligibile to vote");
            }
            else
            {
                Console.WriteLine("Eligible to vote");
            }
            Console.ReadKey();
        }
    }
}
