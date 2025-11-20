using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array with numbers
            int[] numbers = new int[4]
            {
                1, 2, 3, 4
            };
            //Empty list
            List<int> listNumbers = new List<int>();

            //For loop asking 3 times for numbers and adds to the list
            for (int i = 0; i < 3;  i++)
            {
                Console.Write("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            //Remove value from list
            listNumbers.Remove(1);

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
