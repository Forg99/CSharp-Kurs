using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U9_Boolean_Task_in_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 5;
            int num3 = 1;
            int num4 = 2;

            bool isTrue = true;

            bool result1 = isTrue && (num1 > num3) && (num2 < num4);
            bool result2 = isTrue || (num1 < num3) || (num2 > num4);
            bool resultNot = !isTrue;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(resultNot + "\n");


            bool Num1GreaterNum3 = num1 > num3;
            bool Num2LessNum4 = num2 < num4;
            bool Num1EqualNum4 = num1 == num4;
            bool Num2NotEqualNum3 = num2 != num3;


            Console.WriteLine(Num1GreaterNum3);
            Console.WriteLine(Num2LessNum4);
            Console.WriteLine(Num1EqualNum4);
            Console.WriteLine(Num2NotEqualNum3 + "\n");


            bool expressiono1 = (num1 > num3) && (num2 < num4);
            bool expressiono2 = (num1 < num3) || (num2 > num4);

            Console.WriteLine(expressiono1);
            Console.WriteLine(expressiono2);
        }
    }
}
