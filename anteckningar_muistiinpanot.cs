using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //version 1
            Console.WriteLine("Version 1");
            //användarinmatning
            Console.Write("Please give a value to a string variabel: ");

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Conversion succeeded: {num}");
            }
            // bokstäver
            catch (FormatException)
            {
                Console.WriteLine("Bokstäver går inte.");
            }
            // för stora eller små värden
            catch (OverflowException)
            {
                Console.WriteLine("Please input a value smaller than 2 billions");
            }
            // övriga fel
            catch (Exception e)
            {
                // detta visar ett allmänt felmeddelande
                Console.WriteLine($"Error: {e.Message}");
            }

            //version 2
            Console.WriteLine("Version 2");

            // användarinmatning
            Console.Write("Please give a value to a string variabel: ");
            // variabeln definieras
            string variabel = Console.ReadLine();

            /*Det är bättre att ha alltid relaterat till en viss uppgift
            inom en funktion istället för att ha det skrivet in i 
            huvudfunktionen */

            //funktionen påkallas
            if (function(variabel, out int x))
            {
                Console.WriteLine("$The conversion was successful: {x}");
            }
            else
            {
                Console.WriteLine("$The conversion was unsuccessful");
            }

            // funktion
            static bool function(string x, out y)
            {
                try
                {
                    int y = Convert.ToInt32(Console.ReadLine(x));
                    return true;
                }
                // bokstäver
                catch (FormatException)
                {
                    Console.WriteLine("Please do not enter letters.");
                }
                // för stora eller små bokstäver
                catch (OverflowException)
                {
                    Console.WriteLine("Please input a value smaller than 2 billions");
                }
                // övriga fel
                catch (Exception e)
                {
                    // detta visar ett allmänt felmeddelande
                    Console.WriteLine($"Error: {e.Message}");
                }
                y = 0;
                return false;
            }
        }
    }
}

using System;

namespace uppgift_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Användarinmatning
            Console.Write("text: ");
            string användarinmatning = Console.ReadLine();

            //funktionen kallas
            //ifall är sant
            if (funktion(användarinmatning, out önskadDatatyp y))
            {
                //ifall är sannt så skrivs detta ut
                Console.WriteLine($"Framgångsrik omvändning: {y}");
            }
            //ifall är inte sant, dvs falskt
            else
            {
                Console.WriteLine("Misslyckad omvändning.");
            }
        }

        static bool funktion(string parameter1, out önskadDatatyp parameter2)
        {
            try
            {
                parameter2 = Convert.ToönskadDatatyp(parameter1);
                return true; // framgångsrik omvändning
            }
            catch (namnetPåFelkoden)
            {
                //kod hit
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Please do not enter letters.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please input a value smaller than 2 billion.");
            }
            catch (Exception e)
            {
                // This shows a general error message
                Console.WriteLine($"Error: {e.Message}");
            }
            /*ifall databytet felar behövs det fortfarande ett standardvärde till parameter2 för annars felar koden. Värdet behöver dock inte vara 0, utan kan vara vad som helst för värdet används ingenstans. Det föredragna är dock 0??????
            */
            parameter2 = 0;
            // 
            return false; // detta kan skrivas inom varje {} för varje felmeddelande, men det behövs inte
        }
    }
}



// "constructor"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        // "properties"
        public string Name { get; set; }
        public string Age { get; set; }

        // "Constructor to initialise Name and Age"
        public Person(string name, string age)
        {
            Name = name;
            Age = age;
        }

        //"method to display details"
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Create an instance of the Class "Person" using the constructor
            Person person = new Person("Alexander", "37");

            //"Call the method to display the personal information
            person.DisplayInfo();

            Console.ReadLine();
        }
    }
}


// hantering av eventuella fel
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //användarinmatning
                Console.WriteLine("Enter a number: ");

                //användarinmatningen läses ändras till ett heltal och sparar det
                int num = Convert.ToInt32(Console.ReadLine());

                //Det sparade värdet skrivs ut
                Console.WriteLine(num);
            }
            // bokstäver skrivs in
            catch (FormatException)
            {
                Console.WriteLine($"Vänligen inmata bara siffror");
            }
            // för stora eller små bokstäver
            catch (OverflowException)
            {
                Console.WriteLine("Vänligen inmata värden mindre än 2 bilioner");
            }
            // övriga fel
            catch (Exception e)
            {
                // detta visar ett allmänt felmeddelande
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.WriteLine("Slut");

            Console.ReadLine();
        }
    }
}




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calcu = Add(50, 50);
            Console.WriteLine(calcu);

            int num = ReadInt("Enter a number: ");
            int num2 = ReadInt("Enter a second number: ");

            int result = Add(num, num2);
            Console.WriteLine(result);

            // exemepel 2
            string name = ReadString("Enter you name: ");
            int age = ReadString("Enter you age: ");
            string details = UserDetails(name, age);
            Console.WriteLine(details);
            Console.ReadLine();
        }
        static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}";
        }
        static int ReadString(string message)
        {
            Console.Write($"{message}";
            return Console.ReadLine();
        }
        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Add(int a, int b)
        {   
            return a + b; 
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calcu = Add(50, 50);
            Console.WriteLine(calcu);

            // namninmatning
            string message = ReadText("Enter your message: ");
            Console.WriteLine(message);
            Console.ReadLine();

        }

        static string ReadText(string message) // "static" = funktion(?) + string/int etc. + funktionens namn + eventuella parametrar
        {
            Console.Write($"{message} ");
            return Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }    
    } 
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidFunction
{
    internal class Program
    {
        static void Main (string[]args) // inte public static void
        {
            Message();
            CreateAndPrintArray();
            Console.ReadLine();
        }

        static void CreateAndPrintArray()
        {
            int[] number = new int[5] { 1, 2, 3, 4, 5 };
            foreach (var item in number)
            {
                Console.Write($"{item}");
            }
        }
        static void Message()
        {
            Console.WriteLine("Count from 0 to 4!");
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class test // metoden "test"
    {
        public static void something()
        {
            Console.WriteLine()
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // detta kallar på metoden "något (something)" från början 
            test.something(); // denna är utanför, tar minne bara när kallas på

            WelcomeMessage(); // denna är innanför, tar minne fastän inte kallas på

            Console.ReadLine();
        }
        //"static method"
        static void WelcomeMessage() //om denna är inne är den aktiv
        {
            Console.WriteLine("text text");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exempel 1
            // både heltal (int32) och tecken
            //Dictionary<int, string> names = new Dictionary<int, string>
            //{
            //    { 1, "A" },
            //    { 2, "B" },
            //    { 3, "C" }
            //};
            //// utskrift med för-slinga
            //for(int i = 0; i < names.Count; i++)
            //{
            //    KeyValuePair<Int, string> pair = ElementAt[i];
            //    Console.WriteLine($"{pair.Key} - {pair.Value}");
            //}
            //// utskrift med "foreach"
            //foreach(KeyValuePair<int, string> item in names)
            //{
            //    Console.WriteLine($"{pair.Key} - {pair.Value}");
            //}
            //Console.WriteLine();
            // exempel 2

            Dictionary<string, string> dict = new Dictionary<string, string
            {
                {"PU", "Tom" },
                {"PU2", "Anton"}
                {"svenska", "Lotta"}
            };

            if (teachers.TryGetValue("svenska", out string teacher))
            {
                Console.WriteLine(teacher);

                teachers["matematik"] = "A";
            }
            else
            {
                Console.WriteLine("Pu teacher not found");
            }
            // ifall nyckeln finns raderas den
            if (teachers.ContainsKey("matematik"))
            {
                teachers.Remove("matematik");
            }
            else
            {
                Console.WriteLine("Matematikläraren ej hittad");
            }

            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.key} - {item.Value}");
            }
            Console.ReadLine();
        }
    }
}









using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lista eller fält????
            int[] numbers = new InvalidTimeZoneException[4]
            {
                1, 2, 3, 4
            };
            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number");
                // tillsättning till listan/fältet
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }
            // radering av värden från listan/fältet
            listNumbers.Remove(1);

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}


using system.globalization;
using system.threading;
using system.xml.linq;
using system;

int x = convert.toint32(y);
int x = int.parse(y);

int x = convert.toint64(y);
int x = long.parse(y);
long x = convert.toint64(y);
long x = long.parse(y);

float x = convert.tosingle(y);
float x = float.parse(y);

double x = convert.todouble(y);
double x = double.parse(y);

decimal x = convert.todecimal();
decimal x = decimal.parse(y);

char x = convert.tochar(y);
char x = char.parse(y);
char x = y[0];

string x = convert.tostring(y);
string x = string.parse(y);
string x = y.tostring();


using system;

namespace test
{
    public class program
    {
        static void main(string[] args)
        {
            int[] numbers = new int[]
            {
                90, 199, 22, 50, 30
            };

            console.write("enter a number to search: ")
            int search = convert.toint32(console.readline());

            int position = array.indexof(numbers, search);

            if (position > -1) // 0->
            {
                console.writeline($"number {search} has been found at position {position + 1}");
            }
            else
            {
                console.writeline($"number {search} has not been found")
            }

            console.readline()
        }
    }
}
            using system;

namespace test
{
    public class program
    {
        static void main(string[] args)
        {
            int[] numbers = new int[]
                {
                    0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
                }

            //array.clear(numbers, 0, numbers.length);
            array.clear(numbers, 5, 5);

            for (int i = 5; i < 10; i++)
            {
                numbers[i] = default;
            }

            foreach (var item in numbers)
            {
                console.write($"{item} ");
            }

            console.readline()
        }
    }
}


using system;

namespace test
{
    public class program
    {
        static void main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            // lista med "reverse"
            /*
            array.reverse(numbers);

            foreach (var item in numbers)
            {
                console.write($"{item} ");
            }
            */

            int[] sortednumbers = new int[numbers.length];
            int x = 0;

            for (int i = numbers.length; i >= 0; i--)
            {
                sortednumbers[x] = numbers[i];
                x++;
            }

            foreach (var num in sortednumbers)
            {
                console.write($"[num} ");
            }

            console.readline();
        }
    }
}

using system;

namespace test
{
    public class program
    {
        static void main(string[] args)
        {

        }
    }
}

using system;

namespace test
{
    public class program
    {
        static void main(string[] args)
        {
            int[] numbers = { 10, 2, 30, 46, 5, 6, 76, 800, 9 };

            array.sort(numbers); // listan sorteras till formen av det minsta värdet till det största, från vänster till höger

            //för varje (något), jokaista (jotakin) kohden, for each (something)
            foreach (int num in numbers)
            {
                console.writeline("num");
            }

            console.readline()
        }
    }
}

using system;

namespace test
{
    public class program
    {
        static void main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;

            int[] numbers = new int[3]; // "new int[talhit]" ändrar på längden av int[] numbers-listan.

            //exempel 1: hård kod
            /*
            numbers[0] = num1; 
            numbers[1] = num2;
            numbers[2] = num3;
            */
            /*
            console.write("enter a number: ");
            numbers[0] = convert.toint32(console.readline()); // början i 0

            console.write("enter a second number: ");
            numbers[1] = convert.toint32(console.readline());

            console.write("enter a third number: ");
            numbers[2] = convert.toint32(console.readline());

            console.write("enter a third number: ");
            numbers[3] = convert.toint32(console.readline());

            console.write("enter a third number: ");
            numbers[4] = convert.toint32(console.readline());

            console.writeline($"{num1} {num2} {num3}");
            console.writeline($"{numbers[0]}, {numbers[1]}, {numbers[2]}");
            */
            //exempel 2: slinga med längden på listan
            for (int i = 0) // i är inte ett måste i c# och python men nog i java
            {
                console.write("enter a number: ");
                numbers[i] = convert.toint32(console.readline());
            }

            // slinga med längd
            for (int i = 0; i < numbers.length; i++)
            {
                console.write($"{numbers[i]} "); // med mellanslaget kommer det mellanslag i utksriften
            }

            console.writeline();

            // för varje, jokaisesta, for each
            foreach (int num in numbers)
            {
                console.write($"{num} ");
            }

            console.readline() // detta gör att "konsolen" visas till användaren
        }
    }
}

using system;
using system.collections.generic;
using system.linq;
using.system.text;
using system.threading.tasks;

namespace string_literal
{
    internal class program
    {
        static void main(string[] args)
        {
            //console.write("enter your name: ");
            string name = console.readline();

            console.writeline($"your name in {name}");
            /*
                if (name != "")
                    console.writeline("0");

                if (!name.equals(""))
                    console.writeline("1");

                if (string.isnullorempty(name))
                    console.writeline("2");
            */
            if (!string.isnullorempty(name))
            {
                if (name.equals("bob"))
                {
                    console.writeline("rätt namn");
                }
                else
                {
                    console.writeline("fel namn");
                }

            }
            console.readline();
        }
    }
}

// något
using system;
using system.collections.generic;
using system.linq;
using.system.text;
using system.threading.tasks;

namespace string_literal
{
    internal class program
    {
        static void main(string[] args)
        {
            string message = "c# is fun";

            //"char"
            console.writeline(message[0]);
            console.writeline(message[1]);
            console.writeline(message[2]);
            console.writeline(message[3]);
            console.writeline(message[4]);

            for (int i = 0; i < message.length; i++)
            {
                console.readline();
                thread.sleep(1000);
            }

            console.writeline();
            //console.writeline(message.contains("c")); // "true"

            bool contains; false;

            for (int i = 0; i < message.length; i++)
            {
                if (message[i].equals("c"))
                {
                    contains = true;
                }
                /*
                else
                {
                    contains = false;
                }
                */

            }
            console.writeline(contains);
            console.readline();
        }
    }
}


// något
using system;
using system.collections.generic;
using system.linq;
using.system.text;
using system.threading.tasks;

namespace string_literal
{
    internal class program
    {
        static void main(string[] args)
        {
            string pass = "123456";
            string compare = "123456";

            /*
            // version 1
            if (pass == compare)
            {
                console.writeline("korrekt/ oikein/ correct");
            }
            else
            {
                console.writeline("fel/ väärin / wrong");
            }
            */
            // version 2
            /*
            if (pass.equals(compare))
            {
                console.writeline("korrekt/ oikein/ correct");
            }
            else
            {
                console.writeline("fel/ väärin / wrong");
            }
            */
            // version 3
            console.write("enter your name");
            string name = console.readline();

            if (!name.equals(""))
            {
                console.writeline("your name is " + name);
            }
            else
            {
                console.writeline("invalid name input");
            }

            string pass2 = "hello";
            char[] chars = new char[] { 'h', 'e', 'l', 'l', 'o' };
            object newcompare = new string(chars);

            if (pass2.equals(newcompare))
                console.writeline("samma");
            else
                console.writeline("different");

            console.readline();
        }
    }
}

//något
using system;
using system.collections.generic;
using system.linq;
using.system.text;
using system.threading.tasks;

namespace string_literal
{
    internal class program
    {
        static void main(string[] args)
        {
            console.writel("enter your name: ");
            strign name = console.readline();

            //ifall inmatning är insatt gör detta
            if (name != string.empty)
            {
                console.writeline($"your name is [name}");
            }
            else
            {
                console.writeline("name is empty");
            }
            console.readline();
        }
    }
}
//något
using system;
using system.collections.generic;
using system.linq;
using.system.text;
using system.threading.tasks;

namespace string_literal
{
    internal class program
    {
        static void main(string[] args)
        {
            //"concatenation
            string test = string.concat("your name is ", name, "and your age is ", age);
            console.write(test);
            console.write(string test = string concat("your name is ", name, "and your age is ", age));

            //"array"
            string[] names = new string[] { "bo", "jakob", "alexander" }
            console.writeline(string.concat(names));

            console.readline();
        }
    }
}

//ny uppgift
using system;
using system.collections.generic;
using system.linq;
using.system.text;
using system.threading.tasks;

namespace string_literal
{
    internal class program
    {
        static void main(string[] args)
        {

            string speech = "he said \"something"";
            //"pathing" version 1
            string path = "c:\\users\\javascriptcode\\desktop\\c# course\nnewline";

            console.writeline(path);
            console.writeline(speech);
            //"pathing" version 2
            path = @"c:\users\javascriptcode\desktop\c# course" + "\new line";
            console.writeline(path)

            string name = @"hello ""someone";
            console.writeline(name);

            name = "hello 'someone'";
            console.writeline(name);

            console.readline()
        }
    }
}

// uppgift_något
using system;
using system.collections.generic;
using system.componentmodel;
using system.linq;
using system.text;
using system.threading.tasks;

namespace tryparse
{
    internal class program
    {
        static void main(string[] args)
        {
            bool success = true;

            while (success)
            {
                console.write("enter a number: ");
                string numinput = console.readline();
                //int num = convert.toint32(numinput);
                if (int.tryparse(numinput, out int num))
                {
                    console.writeline(num);
                }
                else
                {
                    console.writeline("failed to convert!");
                }
            }


            console.readline();

        }
    }
}


using system;
using system.globalization;

namespace format
{
    internal class program
    {
        static void main(string[] args)
        {
            double value = 1000d / 12.34d; // observation: d

            //formatering
            console.writeline(value);
            console.writeline(string.format("{0:0}", value));
            console.writeline(string.format("{0:0.0}", value));
            console.writeline(string.format("{0:0.00}", value));

            double money = -10d / 3d; //3.3333
            cultureinfo enus = new cultureinfo("en-us");

            // datatyp till string
            console.writeline(money);
            console.writeline(string.format("-10$ / 3$ = {0:0:00}$", money));
            console.writeline(money.tostring("c", enus));
            console.writeline(money.tostring("c0", enus));
            console.writeline(money.tostring("c1", enus));
            console.writeline(money.tostring("c2", enus));

            console.write(money.tostring("c", cultureinfo.currentculture));
            //pund
            console.write(money.tostring("c", cultureinfo.createspecificculture("en-gb"));
            console.write(money.tostring("c", cultureinfo.createspecificculture("en-gb"));
            console.write(money.tostring("c", cultureinfo.createspecificculture("da-dk"));
            console.readline();
        }
    }
}


/*using system;

namespace whileloops
{
    internal class progam
    {
        static void main(string[] args)
        {
             for loop example
            for (int = 0; i < 0; i < 10; i++)
            {
                console.writeline(i);
            }

            int i = 0;

            while(i < 10)
            {
              i++;
              console.writeline(i);
            }

            console.write("enter the first number: ");
            string numberainput = console.readline();
            int numbera = convert.toint32(numberainput);

            console.write("enter the second number: ");
            string numberbinput = console.readline();
            int numberb = convert.toint32(numberbinput);
            console.writeline();

            int answer = numbera * numberb;
            int actualanswer = 0;

            console.write("value of " + numbera + " x " + numberb + ": ");
            console.writeline();
            }
        }
    }
}

using system;

namespace ifstatement
{
    internal class programme
    {
        static void main(string[] args)
        {
            //användarinmatning namn, käyttäjäsyöttö nimi, user input name
            console.write("enter thy name: ");
            string name = console.readline();

            //användarinmatning ålder, käyttäjäsyöttö ikä, user input age 
            console.write("enter thine age: ");
            string ageinput = console.readline();
            int age = convert.toint32(ageinput);

            //utskrift, tulostus, print
            console.writeline();
            console.writeline("thy name is " + name + " and thine age is " + age);



            if (age < 0 || age > 150) //inte : i slutet
            {
                console.writeline("invalid age!");
            }
            else
            {
                if (age >= 18 && age <= 20) //inte : i slutet
                {
                    console.writeline("you are between 18 and 20"); //; med
                }
                else if (age >= 21) //inget ; eller :
                {
                    console.writeline("you are 21 or older");
                }
            }
            
            användarinmatning, käyttäjäsyöttö
            console.write("enter the first number: ");
            string numberainput = console.readline();
            int numbera = convert.toint32(numberainput);

            //användarinmatning, käyttäjäsyöttö
            console.write("enter the second number: ");
            string numberbinput = console.readline();
            int numberb = convert.toint32(numberbinput);

            // int variabel = numa + numb
            inte answer = numbera + numberb;

            //console.write("value of " + number a + " *" + numberb + ": " + answer);
            console.write("value of " + numbera + " * " + numberb + ": " + answer);

            //användarninmatning för att gissa svar
            string answerinput = console.readline();
            inte actualanswer = convert.toint32(answerinput);

            //granskning av svar
            if (answer == actualanswer)
            {
                console.writeline("correct answer");
            }
            else if (answer != actualanswer)
            {
                console.writeline("close but it was wrong");
            }

            console.readline();

        }   
    }
}

using system;

public class class1
{
	static void main(string[] args)
	{
		string textage = "23";
		int age = convert.toint32(textage);
		console.writeline(age);

		string textbignuber = "-90000000000";
		long bignumber = convert.toint64(textbignuber);
		console.writeline(bignumber);

		string textnegative = "-55,2" // text med komma, nummer med punkt

        double negative = convert.todouble(textnegative);
		console.writeline(negative);

		float precision = 5.000000f; //f för att det handlar om "float"
		console.writeline(precision);

		string textmoney = "14,99";
		decimal money = convert.todecimal(textmoney);
		console.writeline(money);

		console.readkey();
	}
}


//c++
