using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Enter the original price of the product");
            string priceInput = Console.ReadLine();
            //Validate and convert the price input
            if(!double.TryParse(priceInput, out double originalPrice) || originalPrice <= 0)
            {
                Console.WriteLine("Invalid price! Please enter a positive number.");
                return;
            }
            //discount input
            Console.Write("Enter the discount type (student/senior/none)");
            string discountType = Console.ReadLine().ToLower();

            //Determine the discount percentage based on type
            double discountPercentage;
            switch (discountType)
            {
                case "student":
                    discountPercentage = 0.15; // 15% discount
                    break;
                case "senior":
                    discountPercentage = 0.20; // 20% discount
                    break;
                case "none":
                    discountPercentage = 0.00; // 0% discount
                    break;
                default:
                    Console.WriteLine("Invalid discount typ! Please enter 'student', 'senior' or 'none'");
                    return;

            }
            //Calculate the discount amount and final price
            double discountAmount = originalPrice * discountPercentage;
            double finalPrice = originalPrice - discountAmount;


            //Output - displays the results
            Console.WriteLine("\nOriginal Price: ${0:F2}", originalPrice);
            Console.WriteLine("discoun Type {0}", char.ToUpper(discountType[0]) + discountType.Substring(1)); //capitalize first letter
            Console.WriteLine("Discountcalculator Amount: {0:F2}", discountAmount);
            Console.WriteLine("Final price: ${0:F2}", finalPrice);

            //Bonus check if final price is a great deal
            if (finalPrice <50)
            {
                Console.WriteLine("This is a great deal!");
            }
        }
    }
}
