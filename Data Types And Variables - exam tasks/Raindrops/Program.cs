using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < n; i++)
            {
                string[] nums = Console.ReadLine().Split();
                long raindropsCount = long.Parse(nums[0]);
                int squareMeters = int.Parse(nums[1]);
                decimal coefficient = raindropsCount / (decimal)squareMeters;
                total += coefficient;
            }
            if (total / density <= 0)
            {
                Console.WriteLine($"{total:f3}");
            }
            else
            {
                Console.WriteLine($"{total/density:f3}");
            }
        }
    }
}
