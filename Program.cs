using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Xml;

namespace Deliverable1_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please create a password.\n");
            Console.WriteLine("The password must conatain:");
            Console.WriteLine("-At least one lowercase letter");
            Console.WriteLine("-At least one uppercase letter");
            Console.WriteLine("-At least minimum 7 characters");
            Console.WriteLine("-At least maximum 12 characters");
            Console.WriteLine("-An exclamation point(!)\n");

            string password = Console.ReadLine();

            if  (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Contains("!")
                && password.Length >= 7 && password.Length <= 12)
            {
                Console.WriteLine("Password valid and accepted");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}