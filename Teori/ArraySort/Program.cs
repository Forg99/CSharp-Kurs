using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                10, 22, 300, 450, 5, 6, 76, 8, 29, 1000
            };

            Array.Sort(numbers);

            foreach(int num in numbers)
            {
                Console.WriteLine($"{num} ");
            }
        }
    }
}
