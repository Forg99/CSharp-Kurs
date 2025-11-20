using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LOOPS
            //THE WRONG WAY
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");

            Console.Write("Typw what you want to repat: ");
            string message = Console.ReadLine();

            Console.Write("How many times do you want to loop? ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Sorry, Enter a value above 0");
            }
            else
            {
                //FOR LOOP
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
                //Example to print out Text x times
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine("Hi");
                }
                //Example to print out loop number
                for(int x = 0; x < loopCounter; x++)
                {
                    Console.WriteLine(x);
                }
                Console.ReadLine();

            }
        }
    }
}

