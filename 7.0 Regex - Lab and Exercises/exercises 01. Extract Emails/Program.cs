using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercises_01.Extract_Emails
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string regex = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]{1,}([-.]\w*)*(\.[a-z]{1,})";

            MatchCollection emails = Regex.Matches(text, regex);
            foreach (Match email in emails)
            {
                Console.WriteLine(email + " ");
            }
        }
    }
}
