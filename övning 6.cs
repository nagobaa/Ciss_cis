using System;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many times should the loop run? ");
            string loopRunInput = Console.ReadLine();
            int loopRun = Convert.ToInt32(loopRunInput);

            for (int i = 1; i < (loopRun + 1); i++)

            {
                Console.WriteLine("Loopcounter" + " " + i);
            }

            Console.WriteLine("The loop has finished");
            Console.ReadKey(); //detta ska in hit
        }
        // Console.ReadKey() // inte hit
    }
}