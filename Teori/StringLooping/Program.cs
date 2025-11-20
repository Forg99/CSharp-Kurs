using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;

namespace StringLooping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is Fun";

            //Char[]
            Console.WriteLine(message[0]);//C
            Console.WriteLine(message[1]);//#
            Console.WriteLine(message[2]);// 
            Console.WriteLine(message[3]);//i

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
                Thread.Sleep(250);//1000ms = 1 seec
            }
            Console.WriteLine();
            Console.WriteLine(message.Contains("bob")); //True or False?

            bool contains = false;

            for (int i = 0;i < message.Length; i++)
            {
                if (message[i].Equals('C'))
                {
                    contains = true;

                }
                else
                {
                    contains = false;

                }
                Console.WriteLine(contains);
            }

        }
    }
}
