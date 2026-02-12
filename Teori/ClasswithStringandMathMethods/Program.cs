using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasswithStringandMathMethods
{
    class Student
    {
        private int totalMarks;
        private int obtainedMarks;

        // Constructor
        public Student(int totalMarks, int obtainedMarks)
        {
            totalMarks = totalMarks;
            obtainedMarks = obtainedMarks;
        }

        // Method to calculate the percentage
        public double CalculatePercentage()
        {
            return (double)obtainedMarks / totalMarks * 100;
        }

        // Method to generate a performance message
        public string GetPerformanceMessage()
        {
            double percentage = CalculatePercentage();

            if (percentage >= 90)
            {
                return $"Excellent! You scored {percentage:F2}%."; // fixed format 2 decimal
            }
            else if (percentage >= 75)
            {
                return $"Good job! You scored {percentage:F2}%.";
            }
            else if (percentage >= 50)
            {
                return $"You passed with {percentage:F2}%. Keep improving!";
            }
            else
            {
                return $"You scored {percentage:F2}%. Better luck next time!";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the total marks: ");
            int totalMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks obtained: ");
            int obtainedMarks = Convert.ToInt32(Console.ReadLine());

            Student student = new Student(totalMarks, obtainedMarks);

            double percentage = student.CalculatePercentage();
            string message = student.GetPerformanceMessage();

            Console.WriteLine($"Percentage: {percentage:F2}%");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
