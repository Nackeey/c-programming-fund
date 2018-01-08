using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_05.Match_Numbers
{
    class Program
    {
        static void Main()
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s)";
            string numbers = Console.ReadLine();

            MatchCollection matches = Regex.Matches(numbers, regex);

            foreach (Match number in matches)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
