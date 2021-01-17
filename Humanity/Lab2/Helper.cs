using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;
using System.Data;

namespace Lab2
{
    static class Helper
    {
              
        public static string StringChecker(string str,int length=0)
        {
            Console.WriteLine($"Enter {str}:");
            string a = Console.ReadLine();
            while (!Regex.IsMatch(a, $"^[A-Z]{{1}}[a-z]{{{length},}}$"))
            {
                Console.WriteLine($"Enter a non-empty name with at least {length} characters and first letter capital");
                a = Console.ReadLine();
            }
            return a;
            
        }

        public static string FacultyNumber()
        {
            Console.WriteLine("Enter Faculty Number:");
            string a = Console.ReadLine();
            while (!Regex.IsMatch(a, @"^(?=.*[0-9])(?=.*[A-Z]).{5,10}$"))
            {
                Console.WriteLine("Wrong input! Number should be in this format AD444D:");
                a = Console.ReadLine();
            }
            return a;
        }

        public static double DoubleCheck(string str,double quantity=0)        
        {
            Console.WriteLine($"Enter {str}:");
            string a = Console.ReadLine();
            while(!Regex.IsMatch(a, @"^[0-9]*(?:[,][0-9]{0,2})?$") || double.Parse(a)<=quantity)
            {
                Console.WriteLine($"Number must be above {quantity} and max 2 decimals (optional):");
                a = Console.ReadLine();
            }
            return double.Parse(a);
        }

        public static int IntCheck(string str,int quantity=0)
        {
            Console.WriteLine($"Enter {str}");
            string a = Console.ReadLine();
            while(!Regex.IsMatch(a, @"^[1-9]*$") || int.Parse(a)>quantity)
            {
                Console.WriteLine($"Number max value should be {quantity}:");
                a = Console.ReadLine();
            }
            return int.Parse(a);
        }       
    }
}
