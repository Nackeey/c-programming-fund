using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Word_Encounter
{
    class Program  //80/100
    {
        static void Main(string[] args)
        {
            string sentences = string.Empty;
            List<string> certainWords = new List<string>();

            string pattern = @"^[A-Z]+.+[\.!?]+$";
            string wordPattern = @"\b[A-Za-z]+\b";

            Regex regex = new Regex(pattern);
            var tokens = Console.ReadLine().ToArray();
            char letter = tokens[0];
            int count = int.Parse(tokens[1].ToString());

            while ((sentences = Console.ReadLine()) != "end")
            {
                Match match = regex.Match(sentences);
                if (match.Success)
                {
                    var wordsMatch = Regex.Matches(sentences, wordPattern);
                    foreach (Match w in wordsMatch)
                    {
                        if (w.Value.Contains(letter))
                        {
                            var wordArray = w.Value.ToCharArray();
                            int checkCounter = 0;
                            for (int i = 0; i < wordArray.Length; i++)
                            {
                                if (wordArray[i] == letter)
                                {
                                    checkCounter++;
                                }
                                if (checkCounter >= count)
                                {
                                    certainWords.Add(w.Value);
                                    checkCounter = 0;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(", ", certainWords));
        }
    }
}
