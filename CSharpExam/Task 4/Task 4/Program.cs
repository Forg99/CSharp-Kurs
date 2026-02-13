using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // all variables in the program were strings
            // all varaibles were changed to doubles to allow for math functions

            Console.Write("Enter the first number: ");
            double input1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double input2 = Convert.ToDouble(Console.ReadLine());



            double sum = Add(input1, input2);
            double difference = Subtract(input1, input2);
            double product = Multiply(input1, input2);
            double quotient = Divide(input1, input2);

            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The difference of the numbers is: {difference}");
            Console.WriteLine($"The product of the numbers is: {product}");
            Console.WriteLine($"The quotient of the numbers is: {quotient}");

            Console.ReadLine();
        }

        static double Add(double num1, double num2)
        {
            return num1 + num2;

        }

        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
            // the previous code (num1 + "-" + num2) treated every character and varaible as strings
            //changed to current form to allow for the intended math functions
        }


        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
            // the previous code (num1 + "*" + num2) treated every character and varaible as strings
            //changed to current form to allow for the intended math functions
        }

        static double Divide(double num1, double num2)
        {
            return num1 / num2;
            // the previous code (num1 + "/" + num2) treated every character and varaible as strings
            //changed to current form to allow for the intended math functions
        }
    }
}
