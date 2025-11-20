using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U22_Logical_error_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 8, 3, 4, 5 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                sum += numbers[i];
            }

            Console.WriteLine("Sum of numbers: " + sum);
            Console.ReadLine();

            /*Console.WriteLine($"Sum of numbers:  {numbers.Sum()}");
            Console.ReadLine();
            */
        }
    }
}
