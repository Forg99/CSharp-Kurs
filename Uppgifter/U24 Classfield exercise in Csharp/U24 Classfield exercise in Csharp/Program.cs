using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U24_Classfield_exercise_in_Csharp
{
    internal class Program
    {
        class Person
        {
            private string firstName {  get; set; }
            private string lastName { get; set; }
            private int age { get; set; }
            private int birthYear { get; set; }
            private string nationality {  get; set; }


           
            public Person(string firstname, string lastname, int agex, int birthyear, string nationalityx)
            {
                firstName = firstname;
                lastName = lastname;
                age = agex;
                birthYear = birthyear;
                nationality = nationalityx;


            }

            public string GetPersonAsString()
            {
                return ($"{firstName} {lastName} {age} {birthYear} {nationality}");
            }
        }
            
            
        static void Main(string[] args)
        {
            Person person1 = new Person("alex", "Carter", 21, 2004, "Canadian");

            Console.WriteLine(person1.GetPersonAsString());

            Person person2 = new Person("Tim", "Rivera", 30, 1995, "American");

            Console.WriteLine(person2.GetPersonAsString());
        }
    }
}
