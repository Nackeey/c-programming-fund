using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab_03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main()
        {
            string regex = @"\b(?:0x)?[0-9A-F]+\b";
            string hexadecimals = Console.ReadLine();

            MatchCollection matches = Regex.Matches(hexadecimals, regex);
            var hexNumbers = matches.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", hexNumbers));
        }
    }
}
