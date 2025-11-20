using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ReturnNameAgePair();
            PrintIntroduction();

            int[] numbers = new int[3];

            for(int i = 0; i < numbers.Length; i++)
            {
                //Console.Write("Enter a number: ");
                //numbers[i] = Convert.ToInt32(Console.ReadLine());

                numbers[i] = ReadNumberFromConsole();
            }
            foreach(var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int[] newNumbers = CreateRandomArray();

            foreach(var item in newNumbers)
            {
                Console.Write(item + " ");

                Console.WriteLine(Add());
            }
        }

        static void something()
        {

        }
        static void Conversion()
        {

        }
        static void Calculation()
        {

        }
        static int Add()
        {
            return 5 + 5;

        }

        static int[] CreateRandomArray()
        {
            return new int[] { 0, 1, 2, };
        }

        static int ReadNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        
        }

        static string ReturnName()
        {
            return "Bob";
        }

        static int ReturnAge()
        {
            return 37;
        }

        static string ReturnNameAgePair()
        {
            return $"{ReturnName()} - {ReturnAge}";
        }
        static void PrintIntroduction()
        {
            Console.WriteLine("Welcome to code C#");

            string name = ReturnName();
            int age = ReturnAge();
            string output = $"Hi my name is {name} and my age is {age}";
            Console.WriteLine(output);
        }
    }
}
