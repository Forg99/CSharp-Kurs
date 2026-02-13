using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        class Game
        {
            private string Name { get; set; }
            private string Publisher { get; set; }
            private int Year { get; set; }
            private string Genre { get; set; }

            public Game(string name, string publisher, int year, string genre)
            {
                Name = name;
                Publisher = publisher;
                Year = year;
                Genre = genre;
            }
        

        public string GetGameData()
        {
            return ($"{Name} {Publisher} {Year} {Genre} ");
        }
    }

        
    
        static void Main(string[] args)
        {
            Game game1 = new Game("Bloons", "Ninja Kiw", 2018, "Tower Defense");
            string x = game1.GetGameData();
            
            List<string> list = new List<string>();
            list.Add(x);
            list.Add()

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            
            
        }
    }
}
