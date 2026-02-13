using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //original input saved as string for tryparse function
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();
            

           //if int.TryParse used so program doesnt crash if input string cannot be converted to int
            if (int.TryParse(numInput, out int num))  
            {
                if (num > 0) //checking if int is positive
                {
                    Console.WriteLine("number is positive");
                }

                else
                {
                    if (num < 0) // checking if int is negative
                    {
                        Console.WriteLine("number is negative");
                    }
                    else
                    {
                        if (num == 0) //checking if int is 0
                        {
                            Console.WriteLine("number is 0");
                        }
                    }
                }
            }

            else  //output if variable cannot be converted to int
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
    
