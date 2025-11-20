using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Steve";
            int age = 32;
            string address = "12th Hammerstreet";

            PrintDetails(name, age, address);
        }

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
