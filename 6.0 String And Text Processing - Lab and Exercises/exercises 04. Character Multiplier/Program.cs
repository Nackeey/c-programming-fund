 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();
            string firstWord = words[0];
            string secondWord = words[1];
            int minLength = Math.Min(firstWord.Length, secondWord.Length);

            int totalSum = 0;
            int secondSum = 0;
            string subString = "";
            if (firstWord.Length != secondWord.Length)
            {
                if (firstWord.Length == minLength)
                {
                    subString = secondWord.Substring(minLength);
                }
                else
                {
                    subString = firstWord.Substring(minLength);
                }
                for (int i = 0; i < subString.Length; i++)
                {
                    totalSum += subString[i];
                }
            }
            for (int i = 0; i < minLength; i++)
            {
                secondSum += firstWord.ElementAtOrDefault(i) * secondWord.ElementAtOrDefault(i);
            }
            Console.WriteLine(totalSum + secondSum);
        }
    }
}
