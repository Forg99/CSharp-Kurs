using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U13_Odd_or_Even_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
           
            if ((num % 2) == 0)
            {
                Console.WriteLine(num + " is Even");
            }
            else
            {
                Console.WriteLine(num + " is Uneven");
            }
        }
    }
}
