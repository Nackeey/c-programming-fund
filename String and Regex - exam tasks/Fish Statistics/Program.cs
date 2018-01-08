using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace match_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string fishLine = Console.ReadLine();

            Regex matchPattern = new Regex(@"(?<tail>[>]*)<(?<body>[\(]+)(?<status>['x-])>)");

            MatchCollection matches = matchPattern.Matches(fishLine);
            int fishCount = 0;

            if (matches.Count == 0)
            {
                Console.WriteLine($"No fish found.");
            }
            foreach (Match match in matches)
            {
                string fish = match.Value;
                fishCount++;
                string tail = match.Groups["tail"].Value;
                string tailType = string.Empty;
                int tailInCm = tail.Length * 2;

                if (tail.Length > 5)
                {
                    tailType = "Long";
                }
                else if (tail.Length > 1 && tail.Length <= 5)
                {
                    tailType = "Medium";
                }
                else if (tail.Length == 1)
                {
                    tailType = "Short";
                }
                string body = match.Groups["body"].Value;
                string bodyType = string.Empty;

                int bodyInCm = body.Length * 2;
                if (body.Length > 10)
                {
                    bodyType = "Long";
                }
                else if (body.Length > 5 && body.Length <= 10)
                {
                    bodyType = "Medium";
                }
                else
                {
                    bodyType = "Short";
                }
                string status = match.Groups["status"].Value;
                string printStatus = string.Empty;
                if (status == "'")
                {
                    printStatus = "Awake";
                }
                else if (status == "-")
                {
                    printStatus = "Asleep";
                }
                else if (status == "x")
                {
                    printStatus = "Dead";
                }
                Console.WriteLine($"Fish {fishCount}: {fish}");
                if (tail.Length < 1)
                {
                    Console.WriteLine($"  Tail type: None");
                }
                else
                {
                    Console.WriteLine($"  Tail type: {tailType} ({tailInCm} cm)");
                }
                Console.WriteLine($"  Body type: {bodyType} ({bodyInCm} cm)");
                Console.WriteLine($"  Status: {printStatus}");
            }
        }
    }
}
