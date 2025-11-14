using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U12_Password_Checker_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password");
            string password1 = Console.ReadLine();

            Console.WriteLine("Enter password again");
            string password2 = Console.ReadLine();

            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                Console.WriteLine("Please enter a password");
            }
            else
            {
                if (password1 != password2)
                {
                    Console.WriteLine("Passwords do not match");
                }
                else
                {
                    // if (password1.Length >= 6)
                    // {Console.WriteLine("Password match");}
                    //    else
                    //{
                    //    Console.WriteLine("Passwords do not match");
                    //}
                    int pass1Length = 0;
                    int pass2Length = 0;

                    foreach (char c in password1)
                    {
                        pass1Length++;
                    }
                    foreach (char c in password2)
                    {
                        pass2Length++;
                    }

                    if ((pass1Length >= 6) && (pass2Length >= 6))
                    {
                        Console.WriteLine("Password match");
                    }
                    else
                    {
                        Console.WriteLine("Password not Long Enough");
                    }
                    
                }
            }
        }
    }
}
