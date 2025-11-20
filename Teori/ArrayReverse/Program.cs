using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2 ,3 , 4, 5
            };
            //Array.Reverse(numbers);

            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Example 2

            int[] sortedNumbers = new int[numbers.Length];
            
            int x = 0;

            for(int i = numbers.Length -1; i >= 0; i--)
            {
                sortedNumbers[x] = numbers[i];
                x++;
            }
            foreach (var num in sortedNumbers)
            {
                Console.Write(num);
            }
        }
    }
}
