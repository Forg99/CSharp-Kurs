using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Set the current culture explicitly
            CultureInfo.CurrentCulture = new CultureInfo("en-US"); // Change to "en-US"

            double value = 1000 / 12.34;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));

            double money = -10D / 3D;
            Console.WriteLine(money);
            Console.WriteLine(string.Format("-$10 / $3 = {0:C2}", money)); // 2 decimal places
            Console.WriteLine(money.ToString("C")); // standard culture currency formating
            Console.WriteLine(money.ToString("C0")); // no decimal places
            Console.WriteLine(money.ToString("C1")); // 1 decimal places
            Console.WriteLine(money.ToString("C2")); // 2 decimal places

            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));


        }
    }
}
