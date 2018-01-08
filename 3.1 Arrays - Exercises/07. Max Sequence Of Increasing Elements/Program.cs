using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_Of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int currentNum = 0;
            int currentSeq = 1;
            int maxSeq = 1;
            int startIndex = 0;
            int lastIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    currentSeq++;
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        startIndex = currentNum;
                    }
                }
                else
                {
                    currentNum = i;
                    currentSeq = 1;
                }
            }
            for (int i = startIndex; i < startIndex + maxSeq; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
