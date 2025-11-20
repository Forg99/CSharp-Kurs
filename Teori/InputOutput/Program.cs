using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Output & Input
            //Console.WriteLine("This is a test");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            //Console.Write("Your name is ");
            //Console.WriteLine(name);
            //Console.Write("and your age is ");
            //Console.WriteLine(age);

            Console.WriteLine("Your name is "+ name +" and your age is " + age);
            Console.ReadLine();
        }
    }
}
