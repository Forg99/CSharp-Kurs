using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[]
                {
                90, 199, 22, 50, 30
                };
            Console.Write("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            //Example 1
            int position = Array.IndexOf(number, search);
            //int position = Array.IndexOf(number, search, 2);
            //int position = Array.IndexOf(number, search, 1, 2);

            //if(position > -1)
            //{
            //    Console.WriteLine($"number {search} has been found at {position +1}");
            //}
            //else
            //{
            //    Console.WriteLine($"number {search} has not been found");
            //}


            //Example 2

            int position = -1;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == search)
                {
                    position = i;
                }
            }

            if(position > -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} has not been found");
            }
        }
    }
}
