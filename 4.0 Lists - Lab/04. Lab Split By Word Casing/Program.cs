using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Lab_Split_By_Word_Casing
{
    public class Program
    {
        public static void Main()
        {
            List<string> text = Console.ReadLine().Split(new[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }
            , StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            foreach (var word in text)
            {
                if (word[0] >= 'a' && word[0] <= 'z')
                {
                    bool mixedCase = false;
                    for (int i = 1; i < word.Length; i++)
                    {
                        if (word[i] < 'a' || word[i] > 'z')
                        {
                            mixedCase = true;
                        }
                    }
                    if (mixedCase)
                    {
                        mixedCaseWords.Add(word);
                    }
                    else
                    {
                        lowerCaseWords.Add(word);
                    }
                }
                else if (word[0] >= 'A' && word[0] <= 'Z')
                {
                    bool mixedCase = false;
                    for (int i = 1; i < word.Length; i++)
                    {
                        if (word[i] < 'A' || word[i] > 'Z')
                        {
                            mixedCase = true;
                        }
                    }
                    if (mixedCase)
                    {
                        mixedCaseWords.Add(word);
                    }
                    else
                    {
                        upperCaseWords.Add(word);
                    }
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}
