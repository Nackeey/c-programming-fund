using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercises_02.Extract_Sentence_by_Keyword
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string[] sentences = text.Split(new char[] { '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = "\\b" + word + "\\b";

            Regex regex = new Regex(pattern);
            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
