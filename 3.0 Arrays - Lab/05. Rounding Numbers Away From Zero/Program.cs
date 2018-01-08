using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers_Away_From_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            foreach (var x in numbers)
            {
                double roundedNum = Math.Round(x, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{x} => {roundedNum}");
            }
             
            /*
            int[] roundedNums = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundedNums[i]}");
            }
            */
        }
    }
}
