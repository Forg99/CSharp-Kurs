using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U17_Dictionary_Case_task_in_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                {99, "Fredrik"},
                {1, "Anton"},

            };
            while (running == true)
            {
                Console.WriteLine("\n ====Student Management Window====");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Remove a student");
                Console.WriteLine("3. display all students");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an alternative(1-4): ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.Write("Assign ID number of student: ");
                        int newID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Assign Name of student");
                        string newName = Console.ReadLine();
                        students.Add(newID, newName);
                        Console.WriteLine($"student ID '{newID}' has been added");
                        break;
                    case 2:
                        Console.Write("Assign ID of student to be removed");
                        int studentToRemove = Convert.ToInt32(Console.ReadLine());
                        if (students.ContainsKey(studentToRemove))
                        {
                            students.Remove(studentToRemove);
                            Console.WriteLine($"student '{studentToRemove}' has been removed");
                        }
                        else
                        {
                            Console.WriteLine("Student was not found in the dictionary");
                        }
                        break;
                    case 3:
                        Console.WriteLine("IDs and students: ");
                        foreach (var student in students)

                        {
                            Console.WriteLine($"{student.Key} - {student.Value}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting....");
                        running = false;
                        return;
                    default:
                        Console.WriteLine("Invalid input! Try again");
                        break;

                }
            }
        }
    }
}
