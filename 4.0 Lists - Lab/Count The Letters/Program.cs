using System;
using System.Collections.Generic;
using System.Linq;


namespace Count_The_Letters
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var counts = new int[26];

            foreach (var symbol in text)
            {
                if (char.IsLetter(symbol))
                {
                    counts[symbol - 'a']++;
                }
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"{(char)(i + 'a')} - {counts[i]}");
                }
            }
        }
    }
}
