using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 8;

            //Arithmetic operators
            Console.WriteLine($"Arithmetic operators");
            Console.WriteLine($"a + b = {a + b}"); //addition
            Console.WriteLine($"a - b = {a - b}"); //subtraction
            Console.WriteLine($"a * b = {a * b}"); //Multiplication
            Console.WriteLine($"a / b = {a / b}"); //Division
            Console.WriteLine($"a % b = {a % b}"); //modules

            //Comparison operators
            Console.WriteLine($"Comparison operators");
            Console.WriteLine($"a == b = {a == b}"); //equal to
            Console.WriteLine($"a != b = {a != b}"); //not equal to
            Console.WriteLine($"a > b = {a > b}"); //greater than
            Console.WriteLine($"a < b = {a < b}"); //less than
            Console.WriteLine($"a >= b = {a >= b}"); //greater than or equal to
            Console.WriteLine($"a <= b = {a <= b}"); //less than or equal to

            //assignment operators
            int c = 20;
            Console.WriteLine($"Assignment operators");
            Console.WriteLine($"c += 5 -> is: {c += 5}"); // C = c + 5
            Console.WriteLine($"c -= 5 -> is: {c -= 5}"); // C = c - 5
            Console.WriteLine($"c *= 5 -> is: {c *= 5}"); // C = c * 5
            Console.WriteLine($"c /= 5 -> is: {c /= 5}"); // C = c / 5
            Console.WriteLine($"c %= 5 -> is: {c %= 5}"); // C = % 5


            //Íncrement and decrement operators
            int d = 10;
            Console.WriteLine($"Assignment operators");
            Console.WriteLine($"d++ is: {d++}"); // Postfix
            Console.WriteLine($"++d is: {++d}"); // prefix
            Console.WriteLine($"d-- is: {d--}"); // postfix
            Console.WriteLine($"--d is: {--d}"); // prefix

            //logical operators

            bool x = true;
            bool y = false;
            Console.WriteLine($"Logical operators");
            Console.WriteLine($"x && y is {x && y}"); // AND
            Console.WriteLine($"x || y is {x || y}"); // OR
            Console.WriteLine($"x ! y is {x || y}"); // NOT

            Console.ReadLine();

        }
    }
}
