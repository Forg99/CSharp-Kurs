using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U10_Operators_in_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 5;
            int num3 = 14;
            int num4 = 8;
            int num5 = 41;
            int num6 = 15;

            int num1num2sum = num1 + num2;
            int num3num4product = num3 * num4;
            int num5num6devision = num5 % num6;

            Console.WriteLine(num1num2sum);
            Console.WriteLine(num3num4product);
            Console.WriteLine(num5num6devision + "\n");

        

            Console.WriteLine(++num6);
            Console.WriteLine(num6++);
            Console.WriteLine(num6--);
            Console.WriteLine(--num6 + "\n");

            int num5operator1 = num5 += 2;
            int num5operator2 = num5 -= 2;
            int num5operator3 = num5 *= 2;
            int num5operator4 = num5 /= 2;
            int num5operator5 = num5 %= 2;

            Console.WriteLine(num5operator1);
            Console.WriteLine(num5operator2);
            Console.WriteLine(num5operator3);
            Console.WriteLine(num5operator4);
            Console.WriteLine(num5operator5);

            Console.ReadLine();
        }
    }
}
