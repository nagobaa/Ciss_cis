using System;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            //raden nedan kan inte vara innanför switch-slingan
            Console.Write("Please enter a grade: ");
            string gradeInput = Console.ReadLine();
            int grade = Convert.ToInt32(gradeInput);

            switch (grade)
            {

                case 5:
                    Console.WriteLine("Excellent");
                    break;

                case 4:
                    Console.WriteLine("Good");
                    break;

                case 3:
                    Console.WriteLine("Satisfactory");
                    break;

                case 2:
                    Console.WriteLine("Ok");
                    break;

                case 1:
                    Console.WriteLine("Needs Improvement");
                    break;

                case 0:
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Please input a grade between 0-5: ");
                    break; // hit ska också "break;"
            }
            Console.ReadKey();
        }
        
    }
}

