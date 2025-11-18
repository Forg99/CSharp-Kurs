using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DaysUntilChrismas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            //Set the date for Christmas this year
            DateTime christmas = new DateTime(today.Year, 12, 24);


            //Check if Christmas has already passed this year
            if(today> christmas)
            {
                //if christmas has passed set the date for next year's christmas
                christmas = new DateTime(today.Year + 1, 12, 24);
            }
            //Calculate the difference in days
            TimeSpan difference = christmas - today;
            int daysUntilChristmas = difference.Days;

            //Display result
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas!");
        }
    }
}
