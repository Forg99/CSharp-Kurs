using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            //bool for if loop on row 50
            bool uniqueWord = false;

            //defining dictionary
            Dictionary<string, string> Words = new Dictionary<string, string>()
            {
                {"frog", "an amphibian" } 
            };

            //while loop to make the program loop back to the menu after being done with each path
            while (running == true)
            {
                Console.WriteLine("\n\n\n====Menu====");
                Console.WriteLine("1. Add a word and its definition");
                Console.WriteLine("2. Remove a word");
                Console.WriteLine("3. display all words and their definition");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an alternative(1-4): ");
                int choice = int.Parse(Console.ReadLine());

                //switch to make the different options in menu work
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter word you wish to add: ");
                        string newWord = Console.ReadLine();
                        


                        //if block checks if the new word exists in "Words"
                        if (uniqueWord == false) 
                        {
                            foreach (var i in Words.Keys)
                            {
                                if (i == newWord)
                                {
                                    Console.WriteLine("This word already exists. Do you want to overwrite it? (yes/no");
                                    string answer = Console.ReadLine();


                                    // if the answer is yes removes previous version of word in "Words" dictionary
                                    // if answer is anything else creates another entry with the same key
                                    if (answer == "yes") 
                                    {                           

                                        Words.Remove(i);
                                        uniqueWord = true;
                                        break;
                                    }
                                    else 
                                    {

                                        break;
                                    }
                                }
                                else //restarts and skips if loop on row 50
                                {
                                    uniqueWord = true;
                                    break;
                                }
                            }
                        }


                        Console.WriteLine("Type definition of word");
                        string newDefinition = Console.ReadLine(); 
                        Words[newWord] = newDefinition;             //adds new word and its definition to the dictionary
                        Console.WriteLine($"new word: {newWord} added");


                        break;
                        
                    case 2:                 //prompts user for a word to remove and removes it if found in "Words" dictionary
                        Console.Write("Type word you wish to remove");      
                        string wordToRemove = Console.ReadLine();
                        if (Words.ContainsKey(wordToRemove))
                        {
                            Words.Remove(wordToRemove);
                            Console.WriteLine($"word '{wordToRemove}' has been removed");
                        }
                        else
                        {
                            Console.WriteLine("word not found");
                        }
                        break;
                    case 3:         //displays all entries in the "Words" dictionary
                        Console.WriteLine("Entered words and their definitions: ");
                        foreach (var word in Words)

                        {
                            Console.WriteLine($"{word.Key} - {word.Value}");
                        }
                        break;
                    case 4:     // closes program
                        Console.WriteLine("Exiting....");
                        running = false;
                        return;
                    default:    //if answer entered in the menu does not match any of the otpions gives error message and sends user back to menu 
                        Console.WriteLine("Invalid input");
                        break;


                            }
                        }
                }
            }
        }
    

    

