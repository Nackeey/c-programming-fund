using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string happyEmos = @":\)|;\)|;\]|:\*|:\]|:\}|;\}|:D|c:|\(:|\[:|\[;|\*:";
            string sadEmos = @":\(|D:|;\(|:\[|;\[|:\{|;\{|\):|:c|\]:|\];";

            List<string> happy = new List<string>();
            List<string> sad = new List<string>();

            string input = Console.ReadLine();

            var happyMatches = Regex.Matches(input, happyEmos);
            foreach (Match match in happyMatches)
            {
                happy.Add(match.Value);
            }

            var sadMatches = Regex.Matches(input, sadEmos);
            foreach (Match match in sadMatches)
            {
                sad.Add(match.Value);
            }
            double happinessIndex = happy.Count / (double)sad.Count;
            string finalFace = string.Empty;

            if (happinessIndex >= 2)
            {
                finalFace = ":D";
            }
            else if (happinessIndex > 1 && happinessIndex < 2)
            {
                finalFace = ":)";
            }
            else if (happinessIndex == 1)
            {
                finalFace = ":|";
            }
            else if (happinessIndex < 1)
            {
                finalFace = ":(";
            }

            Console.Write("Happiness index: ");
            Console.WriteLine($"{happinessIndex:f2} {finalFace}");
            Console.WriteLine($"[Happy count: {happy.Count}, Sad count: {sad.Count}]");
        }
    }
}
