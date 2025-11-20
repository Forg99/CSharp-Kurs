using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Prompt the user to enter a number
                Console.WriteLine("Enter a number");

                //Read user input, convert it to an intager and strore it in the variable
                int num = Convert.ToInt32(Console.ReadLine());

                //Print the entered number to the console
                Console.WriteLine(num);
            }
            //Catch block for handling invalid input
            catch(FormatException)
            {
                Console.WriteLine($"Please enter only numbers!");
            }
            //Catch block for handling numbers that are to large or to small
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a value lower than 2 billion!");
            }
            //Catch block for handling any other error messages
            catch(Exception e)
            {
                //Display a general error message
                Console.WriteLine($"Error: {e.Message}");
            }
            Console.WriteLine("Bye Bye.....");
        }
    }
}
