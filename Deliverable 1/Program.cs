using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Please enter a password. The password must be between 7 and 12 characters while also containing at least one lowercase letter, one uppercase letter, and an exclamation point. ");
                string password = Console.ReadLine();
                if (password.Any(char.IsUpper) &&
                    password.Any(char.IsLower) &&
                    password.Contains('!') &&
                    password.Length >= 7 &&
                    password.Length <= 12)
                    Console.WriteLine("Password valid and accepted.");
                else
                {
                    Console.WriteLine("Error.");
                }
            }
        }
    }
}
