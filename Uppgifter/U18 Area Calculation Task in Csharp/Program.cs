using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U18_Area_Calculation_Task_in_Csharp
{
    internal class Program
    {
     class AreaTriangle
        {
            private double Height { get; set; }
            private double Width { get; set; }

            public AreaTriangle(double height, double width)
            {
                Height = height;
                Width = width;
            }
            public double ReturnArea()
            {
                return  (Height * Width) / 2;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Define Height of Triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Define Width of Triangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            AreaTriangle area = new AreaTriangle(height, width);


            Console.WriteLine($"The Area of the Triangle is: {area.ReturnArea()}");

        }
    }
}
