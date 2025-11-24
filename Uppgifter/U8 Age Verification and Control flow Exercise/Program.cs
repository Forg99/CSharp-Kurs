using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U8_Age_Verification_and_Control_flow_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age: ");
            string StringAge = Console.ReadLine();
            int Age = Convert.ToInt32(StringAge);

            const int LegalAge = 18;

            int Counter = 1;

            var name = ("John");

            if (Age >= LegalAge)
            {
                Console.WriteLine("you are an adult");
            }
            else
            {
                Console.WriteLine("You are under the legal age");
            }

            while (Counter <= 5)
            {
                Console.WriteLine(Counter);
                Counter++;
            }
            Counter--;

            switch (Counter)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;


            }

            
            Console.WriteLine("Hello " + name + ", the result of the switch is " + Counter + " and the result of the loop statement is 1 to 5" );

            Console.ReadLine();
        }
    }
}
