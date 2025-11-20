using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If Statement

            //Console.Write("Enter your age: ");
            //string ageInput = Console.ReadLine();
            //int age = Convert.ToInt32(ageInput);

            //// == > >= < <= != || &&

            //if (age > 18 && age <= 25) {

            //}
            //else if (age >= 26) 
            //{
            //    Console.WriteLine("You are 26 or older");

            //}
            //if (age < 0 || age > 150)
            //{
            //    Console.WriteLine("!Invalid age!");
            //}
            //else
            //{
            //    if(age >= 18 && age <= 25)
            //    {
            //        Console.WriteLine("you are between 18 and 25");

            //    }
            //    else if (age >= 26 && age <= 99)
            //    {
            //        Console.WriteLine("You are 26 or older");
            //    }       Console.WriteLine("You are between 18 and 25");

            //Example 2
            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the first number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answare = numberA * numberB;

            //Console.Write("Value of " + numberA + " x " +  numberB + ": " + answare);
            Console.Write("Value of " + numberA + " x " + numberB + ": " + answare);
            string answareAoutput = Console.ReadLine();
            int actualAnsware = Convert.ToInt32(answareAoutput);

            if(answare == actualAnsware)
            {
                Console.WriteLine("Well done");
            }
            else if (answare != actualAnsware)
            {
                Console.WriteLine("Close but it is wrong");
            }
            Console.ReadLine();

        }
    }
}
