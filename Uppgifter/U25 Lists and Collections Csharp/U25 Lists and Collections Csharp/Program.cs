using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U25_Lists_and_Collections_Csharp
{
    internal class Program
    {
        class Inventory
        {
            private List<string> items  { get; set; }
            private Dictionary <double, int> itemDetails { get; set; }

            public Inventory(List<string> itemS, Dictionary<double , int> itemdetailS)
            {
                items =  itemS;
                itemDetails = itemdetailS;
            }


        }
        static void Main(string[] args)
        {
           //Inventory inventory = new Inventory(List<string> tablet,Dictionary<double, int>)
        }
    }
}
