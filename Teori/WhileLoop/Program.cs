using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example Loop vs While
            ////loop
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int x = 0;
            ////While loop
            //while (x < 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);
            Console.WriteLine();

            int answare = numberA * numberB;
            int actualAnsware = 0;

            Console.Write("Value of " +numberA + " * " + numberB+ ": ");
            Console.WriteLine();

            //while (answare != actualAnsware)
            //{
            //    Console.Write("enter your answare: ");
            //    string answareoutput = Console.ReadLine();
            //    actualAnsware = Convert.ToInt32(answareoutput);


            //    if(answare != actualAnsware)
            //    {
            //        Console.WriteLine("close but it was wrong");
            //    }
                
            //}
            do
            {
                Console.Write("Enter your answare");
                string answareInput = Console.ReadLine();
                actualAnsware = Convert.ToInt32(answareInput);

                if(answare != actualAnsware)
                {
                    Console.WriteLine("Close but it was wrong");
                    Console.WriteLine();
                }
                
            } while (answare != actualAnsware);

            Console.WriteLine("Well done");
            Console.ReadLine();
        } 
    }
}
