using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int currentIndex = 0;
            int currentLen = 1;
            var longestLen = 1;
            var longestIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLen++;

                    if (currentLen > longestLen)
                    {
                        longestLen = currentLen;
                        longestIndex = currentIndex;
                    }
                }
                else
                {
                    currentLen = 1;
                    currentIndex = i;
                }
            }
            for (int i = longestIndex; i < longestIndex + longestLen ; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
