using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer");
            int intx = int.Parse(Console.ReadLine());
            //defining the var as "var"x so it can be called on later

            Console.WriteLine("please enter a double");
            double doublex = double.Parse(Console.ReadLine());


            Console.WriteLine("please enter a float");
            float floatx = float.Parse(Console.ReadLine());


            Console.WriteLine("please enter a string");
            string stringx = Console.ReadLine();


            Console.WriteLine($"int: {intx} \ndouble: {doublex} \nfloat {floatx} \nstring: {stringx}\n ");
            //calling on and printing the previously defined variables

            Console.WriteLine("an integer is a variable that can store whole numbers \n");
            Console.WriteLine("a double is a varaible that can store up to 15 decimal numbers with precision\n");
            Console.WriteLine("a float is variable that can store up to 7 decimal numbers with precision\n");
            Console.WriteLine("a string is varaible that stores text");
            //Printing a short explanation of the above used variable types


            Console.ReadLine();
        }
    }
}
