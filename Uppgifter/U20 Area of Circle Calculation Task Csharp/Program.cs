using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U20_Area_of_Circle_Calculation_Task_Csharp
{
    internal class Program
    {
        class Circle
        {
            public double Radius;

            //Constructor
            public Circle(double radius)
            {
                Radius = radius;
            }

            //Method to calculate the Perimeter
            public double GetPerimeter()
            {
                return 2 * Math.PI * Radius;

            }

            //Method to calculate the Area
            public double GetArea()
            {
                return Math.PI * Math.Pow(Radius, 2);

            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle:  ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle(radius);


            double perimeter = circle.GetPerimeter();
            double area = circle.GetArea();

            Console.WriteLine($"The perimeter of the Circle is:  {perimeter:F2}");
            Console.WriteLine($"The Area of the circle is: {area:F2}");

        }
    }
}
