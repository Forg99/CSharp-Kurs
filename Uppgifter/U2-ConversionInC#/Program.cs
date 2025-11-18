using System;


namespace _2_ConversionInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsText = "10"; //defining string variable
                int number = int.Parse(numberAsText); //converting string to integer using Parse
            Console.WriteLine(number); //Printing the integer

        }
    }
}
