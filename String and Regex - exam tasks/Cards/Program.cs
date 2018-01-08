using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string pattern = (@"([1]?[0-9JQKA])([SHDC])");

            Regex regex = new Regex(pattern);
            List<Match> cards = new List<Match>();
            MatchCollection matches = regex.Matches(inputLine);

            foreach (Match match in matches)
            {
                int power = 0;
                if (int.TryParse(match.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                cards.Add(match);
            }
            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
