using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5_Switch_Statements_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());


            switch (grade)
            {
                case 0:
                    Console.WriteLine("Fail");
                    break;
                case 1:
                    Console.WriteLine("Needs Improvement");
                    break;
                case 2:
                    Console.WriteLine("Ok");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Exellent");
                    break;
            }
            Console.ReadLine();

        }
    }
}
