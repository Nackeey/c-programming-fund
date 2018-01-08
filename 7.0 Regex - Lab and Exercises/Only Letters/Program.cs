using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(?<digits>[0-9]+)(?<letter>[A-Za-z]{1})");
            MatchCollection matches = pattern.Matches(input);

            foreach (Match m in matches)
            {
                string digits = m.Groups["digits"].Value;
                string letter = m.Groups["letter"].Value;
                
                input = Regex.Replace(input, digits, letter);
            }
            Console.WriteLine(input);
        }
    }
}
