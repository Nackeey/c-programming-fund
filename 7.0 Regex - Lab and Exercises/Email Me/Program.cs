using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string charsBefore = @".+(?=[@])";
            string charsAfter = @"(?<=[@]).+";
                    
            Match partOne = Regex.Match(email, charsBefore);
            Match partTwo = Regex.Match(email, charsAfter);

            if (partOne.Length - partTwo.Length >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
