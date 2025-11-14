using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U11_Message_Printer_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("C# is fun, I am going to code C# tomorrow");
                var message = Console.ReadLine();

                Console.WriteLine(message);


                char[] messageArray = message.ToCharArray();

                Array.Reverse(messageArray);
                Console.WriteLine(messageArray);
                Array.Reverse(messageArray);


                foreach (char c in messageArray)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine("\n");

                Array.Reverse(messageArray);
                foreach (char c in messageArray) Console.WriteLine(c);


                


            }
        }
    }
}
