using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructor
{
    class Person
    {
        //Properties of the class
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructor to initialize Name and Age
        public Person(string name, int age) 
        { 
        Name = name; //set Name prperty
        Age = age; //set Age prperty
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name:  {Name}, Age {Age}");
        }

        //
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an Instanc of the "Person" class using the constructor
            Person person = new Person ("Alice", 25);

            //Call teh method to display the person details
            person.DisplayInfo();

        }
    }
}
