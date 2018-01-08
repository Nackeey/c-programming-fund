using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSumBoundary = int.Parse(Console.ReadLine());

            var combinations = 0;
            var sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int k = 1; k <= m; k++)
                {
                    combinations++;
                    sum = 3 * (i * k) + sum;
                    if (sum >= maxSumBoundary)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSumBoundary}");
                        break;
                    }                  
                }
                if (sum >= maxSumBoundary)
                {
                    break;
                }
            }
            if (sum < maxSumBoundary)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }           
        }
    }
}
