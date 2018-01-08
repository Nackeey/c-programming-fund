using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_01.Math_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection matches = Regex.Matches(names, pattern);
            foreach (Match m in matches)
            {
                Console.Write(m.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
