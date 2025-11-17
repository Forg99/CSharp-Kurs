using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U14_Array_multiplication_in_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length= 6;

            Console.WriteLine($"Multiplication Table for {num}:");

            int[] array = new int [length];
            for (int i = 0; i < length; i++)
            {
                array[i] = num * i;
                
                Console.WriteLine(array[i]);

            }

            

        }
    }
}
