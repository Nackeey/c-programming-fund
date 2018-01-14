using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            nums.RemoveAll(x => x % 2 != 0);
            
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] = nums[i] > nums.Average() ? nums[i] += 1 : nums[i] -= 1;
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
