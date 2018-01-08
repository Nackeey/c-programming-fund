using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int currentLen = 1;
            int mostFreqNum = 0;
            int longestLen = 1;
            int currentNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentNum = numbers[i];
                        currentLen++;
                        if (currentLen > longestLen)
                        {
                            longestLen = currentLen;
                            mostFreqNum = currentNum;
                        }
                    }
                }
                currentLen = 1;
            }
            Console.WriteLine(mostFreqNum);
        }
    }
}
