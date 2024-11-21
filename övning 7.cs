using System;

namespace test
{
	public class Program
	{
		static void Main(string[] args)
		{
            // version 1 while-loop
            Console.WriteLine("This is version 1 of the while-loop");

			int counter = 1;

			while (counter <= 5)
			{
				Console.WriteLine("The value of the int variable counter is:" + " " + counter);
				counter += 1;
			}

			Console.WriteLine("The loop of version 1 has finished");
			
			// version 2 while-loop
			Console.WriteLine("\nThis is version 2 of the while-loop");

			int counter2 = 1;
			
			do
			{
				Console.WriteLine("The value of the int variable counter is:" + " " + counter2);
				counter2 += 1;
			} while (counter2 <= 5);
            
			Console.WriteLine("The loop of version 2 has finished");
			Console.ReadKey();
		}
	}
}
