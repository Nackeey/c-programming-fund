using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToUpper();

            StringBuilder result = new StringBuilder();

            foreach (Match m in Regex.Matches(text, @"([^0-9]+)([\d]+)"))
            {
                string word = m.Groups[1].Value;
                int count = int.Parse(m.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
            int uniqs = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqs}");
            Console.WriteLine(result);
        }
    }
}
