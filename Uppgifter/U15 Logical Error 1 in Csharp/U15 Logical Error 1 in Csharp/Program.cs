using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U15_Logical_Error_1_in_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int[] numbers = { 10, 20, 5, 30, 25 };
                int max = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }


                Console.WriteLine($"The maximum value in the array is: {max}");

            Console.ReadLine();
            //I also found this solution
            //int[] numbers = { 10, 20, 5, 30, 25 };

            //Console.WriteLine($"The maximum value in the array is: {numbers.Max()}");



            //Console.ReadLine();


        }
        }
    }

    


    
 
