using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int variables
            int num1 = 5;
            int num2 = 50;
            int num3 = 500;


            //Example 1
            //Create an array named numbers that can hold 5 int values
            int[] numbers = new int[5];

            numbers[0] = num1;// first poition
            numbers[1] = num2;// second position
            numbers[2] = num3;// third position

            /*
            //Store values in specific positions of the array
            numbers[0] = num1;// first poition
            numbers[1] = num2;// second position
            numbers[2] = num3;// third position

            Console.WriteLine($"Array vlaues: {numbers[0]}, {numbers[1]}, {numbers[2]}");
            */

            Console.Write("Enter a number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1}, {num2}, {num3}");

            Console.WriteLine($"Array values: {num1}, {num2}, {num3}");

            //Example 2 : Loops with arrays

            //Create a new array of 5 int
            int[] numbers2 = new int[5];

            //Use a for loop to fill the array with user input
            //The loop runs once for each element in the array "Length = 5"
            for(int i = 0; i < numbers2.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers2[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Use another for loop to print all array elements "Values"
            for(int i = 0; i < numbers2.Length;i++)
            {
                Console.Write($"{numbers2[i]}");
            }

            //Example 2.5: using for each loop
            //foreach is a simpler way to go through all elemants in an array
            foreach (int num in numbers2)
            {
                Console.Write($"{num}");
            }
        }
    }
}
