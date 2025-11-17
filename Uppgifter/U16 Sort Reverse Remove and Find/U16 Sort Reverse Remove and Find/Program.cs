using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16_Sort_Reverse_Remove_and_Find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numarray = { 45, 12, 78, 89, 23 };

            Array.ForEach(numarray, Console.WriteLine);

            Console.WriteLine("\n");

            Array.Sort(numarray);
            Array.ForEach(numarray, Console.WriteLine);

            Console.WriteLine("\n");
            
            Array.Reverse(numarray);
            Array.ForEach(numarray, Console.WriteLine);

            Console.WriteLine("\n");

            int item = 78;
            List<int> nums = new List<int>(numarray);
            nums.RemoveAt(nums.IndexOf(item));
            numarray = nums.ToArray();
            Array.ForEach(numarray, Console.WriteLine);

            Console.WriteLine("\n");

            int x = 0;

            foreach (int num in numarray)
            {
                if (num == 34)
                {
                    x++;
                    break;
                }
            }

            if (x < 0)
            {
                Console.WriteLine("Number 34 Does Exist");
            }
            else
            {
                Console.WriteLine("Number 34 Doesn't Exist");
            }
            

  

        }

    }
}
