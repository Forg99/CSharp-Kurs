using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool success = false;

            //try
            //{
            //    Console.Write("Enter a number");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine(success ? "works" : "Oh no");

            Console.WriteLine("Enter a number: ");
            if(TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("success "+ result);
            }
            else
            {
                Console.WriteLine("Oh no");
            }

            static bool TryParse(string input, out int result)
            {
                result = -1;
                try
                {
                    result = Convert.ToInt32(input);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
