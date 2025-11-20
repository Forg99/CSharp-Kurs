using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            if(message.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if(!name.Equals(""))
            {
                Console.WriteLine("Your name is " + name);
            }
            else
            {
                Console.WriteLine("Invalid name input");
            }

            //Array with 5 char values
            char[] chars = new char[] { 'H', 'E', 'L', 'O' };
            object newCompare = new string();

            if (message == newCompare)
                Console.WriteLine("Same");
            else
            {
                Console.WriteLine("Different");
            }
        }
    }
}
