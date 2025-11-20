using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> subjects = new Dictionary<string, string>
            {

                {"PU", "Tom" },
                {"PU", "Anton" }
            };
            Console.WriteLine("Welcome to Practicum");

            while(true)
            {
                Console.WriteLine("\n Välj ett alternativ: ");
                Console.WriteLine("1. Lägg till ämne");
                Console.WriteLine("2. Ta bort ämne");
                Console.WriteLine("3. Visa alla ämnen och deras lärare");
                Console.WriteLine("4. Exit");

                Console.Write("Ange ditt alternativ: ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.Write("Ange namnet på ämnet: ");
                        string newSubject = Console.ReadLine();
                        Console.WriteLine("Ange namnet på läraren for det nya ämnet: ");
                        string newTeacher = Console.ReadLine();
                        subjects.Add(newSubject, newTeacher);
                        Console.WriteLine($"Ämne '{newSubject}' har lagts till");
                        break;
                    case 2:
                        Console.Write("Ange namnet på ämnet som ska tas bort");
                        string subjectToRemove = Console.ReadLine();
                        if(subjects.ContainsKey(subjectToRemove))
                        {
                            subjects.Remove(subjectToRemove);
                            Console.WriteLine($"ämne '{subjectToRemove}' har tagits bort");
                        }
                        else
                        {
                            Console.WriteLine("Ämnet hittades inte i dictionaryt");
                        }
                        break;
                    case 3:
                        Console.WriteLine("ämnen och deras lärare: ");
                        foreach(var subject in subjects)

                        {
                            Console.WriteLine($"{subject.Key} - {subject.Value}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting....");
                        return;
                    default:
                        Console.WriteLine("Invalid input! Försök igen");
                        break;

                }
            }
        }
    }
}
