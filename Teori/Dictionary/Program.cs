using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1

            //Dictionary<int, string> names = new Dictionary<int, string>
            //{
            //    {1, "bob"},
            //    {2, "Steve"},
            //    {3, "bill"},

            //};

            //for(int i = 0; i < names.Count; i++)
            //{
            //    KeyValuePair<int, string> pair = names.ElementAt(i);
            //    Console.WriteLine($"{pair.Key} - {pair.Value}");
            //}

            //foreach(KeyValuePair<int, string> items in names)
            //{
            //    Console.WriteLine($"{items.Key} - {items.Value}");
            //}

            //Example 2
            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"PU", "Tom" },
                {"PU2", "Anton" },
                {"Svenska", "Göran" }
            };

            //Search for specific value
            if (teachers.TryGetValue("Svenska", out string teacher))
            {
                //Add to Dictionary
                teachers["English"] = "Sofi";
            }
            else
            {
                Console.WriteLine("PU teachers not found");
            }
            if(teachers.ContainsKey("Math"))
            {
                //Remove from dictionary
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }
            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
