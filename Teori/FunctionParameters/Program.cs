using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calc = Add(50, 50);
            Console.WriteLine(calc);


            int num = ReadInt("Enter a number: ");
            Console.WriteLine(num);


            int num2 = ReadInt("Enter a number2: ");
            Console.WriteLine(num2);


            int firstnum = ReadInt("Enter the first number: ");
            int secondnum = ReadInt("Enter the second number: ");


            int result = Add(firstnum, secondnum);
            Console.WriteLine(result);


            string name = ReadString("Enter your name: ");
            int age = ReadInt("Enter your age: ");
            string details = UserDetails(name, age);
            Console.WriteLine(details);

        }

        static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}!";
        }

        static string ReadString(string message)
        {
            Console.Write($"{message}");
            return Console.ReadLine();
        }
        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
