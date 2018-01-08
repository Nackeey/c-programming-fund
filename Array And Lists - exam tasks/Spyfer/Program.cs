using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int i = 0; i < nums.Count; i++)
        {
            int current = nums[i];

            if (i != 0 && i != nums.Count - 1)
            {
                int sumOfNeighbours = nums[i - 1] + nums[i + 1];

                if (current == sumOfNeighbours)
                {
                    nums.RemoveAt(i + 1);
                    nums.RemoveAt(i - 1);
                    i = 0;
                }
            }
            else if (i == 0 && current == nums[i + 1])
            {
                nums.RemoveAt(i + 1);
                i = 0;
            }
            else if (i == nums.Count - 1 && current == nums[i - 1])
            {
                nums.RemoveAt(i - 1);
                i = 0;
            }
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}