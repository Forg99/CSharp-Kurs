using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String variable & int variable
            string name = "Abe";
            int age = 25;

            //Print variables
            Console.Write(name);
            Console.Write(age);
            Console.WriteLine();

            //Print differently
            Console.Write("Name: " + name);
            Console.Write("Age: " + age);
            Console.WriteLine();

            //Print again but make it look nicer
            Console.WriteLine("Name: " + name + "\nAge: " + age);

            Console.WriteLine("Your name is {0}, and your age is {1}", name, age);

            Console.WriteLine("Name: {0}\nAge: {1}", name, age);


        }
    }
}
