using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_if_statements_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote ");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are not eligble to vote ");
            }
        }
    }
}
