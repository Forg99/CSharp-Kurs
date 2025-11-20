using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericFormattingExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a numeric value
            double number = 12345.6789;
            int number2 = 2;

            //Standard numeric format strings
            Console.WriteLine("Standard Numeric Format String:");
            Console.WriteLine("C: " + number.ToString("C")); // Currency standard
            Console.WriteLine("D: " + number2.ToString("D")); // Decimal
            Console.WriteLine("E: " + number.ToString("E")); // Exponential
            Console.WriteLine("F: " + number.ToString("F")); // Fixed-point
            Console.WriteLine("G: " + number.ToString("G")); // General
            Console.WriteLine("N: " + number.ToString("N")); // Number
            Console.WriteLine("P: " + (number / 100).ToString("P")); // Precentage
            Console.WriteLine("X: " + ((int)number).ToString("X"));

            //Custom numeric format string
            Console.WriteLine("\nCustom Numeric Format Strings:");
            Console.WriteLine("0.00: " + number.ToString("0.00")); // Two decimal
            Console.WriteLine("#,##0.00: " + number.ToString("#,##0.00")); // Thousands separator and two decimal places
            Console.WriteLine("(0.00: )" + number.ToString("(0:00)")); // Parentheses for negative numbers and two decimal places
        }
    }
}
