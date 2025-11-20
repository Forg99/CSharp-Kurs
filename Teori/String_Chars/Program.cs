using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string name = "Bob";
            char letter = 'a';

            Console.WriteLine(name);
            Console.WriteLine(letter);

            //Change the variables value
            name = "Dave";
            letter = 'b';

            Console.WriteLine("Your name is: ");
            Console.WriteLine(name);

            Console.WriteLine("\nYour letter is: ");
            Console.WriteLine(letter);

        }
    }
}
