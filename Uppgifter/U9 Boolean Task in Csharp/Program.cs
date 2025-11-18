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
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 1;

            bool isTrue = true;

            bool result1 = isTrue && (num1 > num3) && (num2 < num4);
            bool result2 = isTrue || (num1 < num3) || (num2 > num4);
            bool resultNot = !isTrue;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(resultNot);

        }
    }
}
