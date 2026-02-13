using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Bob", "Steve", "Nina" };

            int[] intArray = { 5, 57, 87, 1, 150, 32, 14 };


            foreach (string i in stringArray)
            {
                Console.WriteLine("goodbye " + i);
            }
            //prints goodbye + the names in stringArray


            Array.Sort(intArray); //sorts intArray in ascending order

            int[] newIntArray = intArray.Take(intArray.Length-1).ToArray();
            //creates new array without the last element


            Array.ForEach(newIntArray, Console.WriteLine); 
            //prints each int in newIntArray

            Console.ReadLine();
        }
    }
}
