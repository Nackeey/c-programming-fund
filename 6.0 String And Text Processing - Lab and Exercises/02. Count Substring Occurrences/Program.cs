using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int matchCounter = 0;
            int startIndex = -1;
            while (true)
            {
                startIndex = text.IndexOf(word, startIndex +1);
                if (startIndex == -1)
                {
                    break;
                }
                else
                {
                    matchCounter++;
                }
            }
            Console.WriteLine(matchCounter);
        }
    }
}
