using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercises_05.Key_Replacer
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var startKey = @"^[A-Za-z]+[<|\\]";
            var endKey = @"[<|\\][A-Za-z]+$";

            var firstKey = Regex.Match(input, startKey);
            var secondKey = Regex.Match(input, endKey);

            var firstk = firstKey.Value.TrimEnd('<', '|', '\\');
            var secondk= secondKey.Value.TrimStart('<', '|', '\\');

            string pattern = $"{firstk}(?<result>.*?){secondk}";

            var text = Console.ReadLine();

            var sb = new StringBuilder();

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match item in matches)
            {
                sb.Append(item.Groups["result"].Value);
            }
            Console.WriteLine(sb.Length > 1 ? sb.ToString() : "Empty result");
        }
    }
}
