using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool succes = true;

            while (succes)
            {
                Console.WriteLine("Enter a number");
                string numInput = Console.ReadLine();

                if(int.TryParse(numInput, out int num))
                {
                    succes = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert");
                }
            }
        }
    }
}
