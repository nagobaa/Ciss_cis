using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter hight: ");
            string heightInput = Console.ReadLine();
            int heigth = Convert.ToInt32(heightInput);
            Console.Write("Please enter width: ");
            string widthInput = Console.ReadLine();
            int width = Convert.ToInt32(widthInput);

            Console.WriteLine($"The area of the triangel is {area(heigth, width)}.");

        }
        static int area (int height, int width)
        {
            return (height * width) / 2;
        }
    }
}
