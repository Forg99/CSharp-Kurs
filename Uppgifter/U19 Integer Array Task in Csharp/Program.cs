using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U19_Integer_Array_Task_in_Csharp
{
    internal class Program
    {
       


        // creating a function that returns the sum of element in an array
        static int SumOfNumbers(int[] values) 
        {
            int x = 0;
            foreach (int value in values) 
            { 
                x = x + value;
            }

            return x;
        }

        static void Main(string[] args)
        {
            //array
            int[] numarray = { 0, 1, 2, 3, 4, 5 };

            //printing the sum of the elements in the array
            Console.WriteLine(SumOfNumbers(numarray));
            
            //Printing number of elements in the array
            Console.WriteLine(numarray.Length);

            //using if statement to check if there are any elemnts in the array
            if (SumOfNumbers(numarray) > -1)
            {
                Console.WriteLine($"the total is {SumOfNumbers(numarray)}");
            }
            else if(SumOfNumbers(numarray) <= -1)
            {
                Console.WriteLine($"the total is {SumOfNumbers(numarray)}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }

            //checking if there are elements in the array in a way that works based on the number of elements instead of the sum 
            /*if (numarray.Length > 0)
            {
                Console.WriteLine($"the total is {SumOfNumbers(numarray)}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }*/

        }

    }
}
