using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>
            {
                "Coffe", "Milk"
            };

            Console.WriteLine(shoppingList.IndexOf("Milk"));

            Console.Write("Enter an item to search for: ");
            string search = Console.ReadLine();

            if(FindInList(search, shoppingList, out int index))
            {
                Console.WriteLine($"Found {search} at index {index}");
            }
            else
            {
                Console.WriteLine("Item not Found");
            }
        }

        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }
            return index > -1;
        }
    }
}
