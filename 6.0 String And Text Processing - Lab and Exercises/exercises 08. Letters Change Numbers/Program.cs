using System;
using System.Collections.Generic;
using System.Linq;

namespace exercises_08.Letters_Change_Numbers
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            foreach (var word in text)
            {
                double tempsum = 0;
                var firstLetter = word.First();
                var lastLetter = word.Last();
                double number = double.Parse(word.Substring(1, word.Length - 2));

                if (char.IsLower(firstLetter))
                {
                    tempsum = number * (firstLetter - ('a' - 1));
                }
                else
                {
                    tempsum = number / (firstLetter - ('A' - 1));
                }
                if (char.IsLower(lastLetter))
                {
                    tempsum += lastLetter - ('a' - 1);
                }
                else
                {
                    tempsum -= lastLetter - ('A' - 1);
                }
                sum += tempsum;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
