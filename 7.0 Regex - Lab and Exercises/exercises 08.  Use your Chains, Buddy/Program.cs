using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercises_08.Use_your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex paragraphReg = new Regex(@"<p>(?<message>.+?)<\/p>");
            var paragraphs = paragraphReg.Matches(input)
                .Cast<Match>()
                .Select(a => a.Groups["message"].Value)
                .Select(a => Regex.Replace(a, @"[^a-z0-9]+", " "))
                .Select(a => Regex.Replace(a, @"\s+", " "))
                .ToArray();

            for (int i = 0; i < paragraphs.Length; i++)
            {
                paragraphs[i] = Rot13ToString(paragraphs[i]);
            }
            foreach (var item in paragraphs)
            {
                Console.Write(item);
            }
        }

        private static string Rot13ToString(string word)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                sb.Append(Rot13(word[i]));
            }
            return sb.ToString();
        }

        private static char Rot13(char v)
        {
            if (!char.IsLetter(v))
            {
                return v;
            }

            var offset = char.IsLower(v) ? 'a' : 'A';
            var rotatedLetter = (char)((v - offset + 13) % 26 + offset);
            return rotatedLetter;
        }
    }
}
 