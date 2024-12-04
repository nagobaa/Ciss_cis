using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift20
{
    class Circle
    {
    
        public double Radius { get; set; }

        public Circle (double radius)
        {
            Radius = radius;
        }
        
        // void är för funktioner som återlämnar inga värden
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(1.5);
            double area = circle1.CalculateArea();
            Console.WriteLine($"Area of the circle is: {area}");
        }
    }
}
