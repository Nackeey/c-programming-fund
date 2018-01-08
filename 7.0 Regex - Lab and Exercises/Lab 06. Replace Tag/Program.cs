using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_06.Replace_Tag
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replacement = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(input, pattern, replacement);

                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }
        }
    }
}
