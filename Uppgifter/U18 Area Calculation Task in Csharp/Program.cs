using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U18_Area_Calculation_Task_in_Csharp
{
    internal class Program
    {
        class Proportions
        {
            public double Height { get; set; }
            public double Width { get; set; }

            public Proportions(double height, double width)
            {
                Height = height; 
                Width = width;
            }
            public double GetArea()
            {
                return Height * Width / 2;
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Enter the Height and Width: ");
        }
    }
}
