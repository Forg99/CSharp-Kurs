using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Defines the namespace for the program
namespace Functions
{
    //A class is a blueprint or a template used to create onjects in C#
    //It contains data (Fields, properties) and behavior(methods, functions)
    //In this example the "Test" Class defines a static method that can be used without creating an object of the class
    class test
    {
        //static method named "something" that prints text and blank line to the console
        public static void something()
        {
            Console.WriteLine("Test");
            Console.WriteLine();
        }
    }
    //The program class contains the Main "method"
    //Which is the entry point of every C# Console application
    //When you run the program, the code inside Main() executes first
    internal class Program
    {
        //The starting point of the program
      
        static void Main(string[] args)
        {
            //Calls the static method "something" from the test class
            test.something();
            //Calls another method defines below to print a welcome message
            WelcomeMessage();
            
        }
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome, Let's code some C#");
        }
    }
}
