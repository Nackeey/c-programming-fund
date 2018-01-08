using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            var minIndex = Math.Min(num1 , num2);
            var maxIndex = Math.Max(num1 , num2);
            
            for (int i = minIndex; i <= maxIndex; i++)
            {
              Console.WriteLine(i);
            }
        }
    }
}
