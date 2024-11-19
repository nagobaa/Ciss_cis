using System;

namespace testpublic
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //"thy" innan konsonant, "thine" innan vokal
            Console.Write("Plese enter thy name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + " " + name);
        }
    }
}
