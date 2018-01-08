using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var current = 1;
            while (n > 0)
            {
                Console.WriteLine(current);
                sum += current;
                n--;
                current = current + 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
