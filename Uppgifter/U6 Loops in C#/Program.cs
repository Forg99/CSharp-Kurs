using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U6_Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value of how many times the loop should run: ");
                string num = Console.ReadLine();
            int X = Convert.ToInt32(num);

            for (int i = 1; i <= X; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("The Loop has Finnished");
        }
    }
}
