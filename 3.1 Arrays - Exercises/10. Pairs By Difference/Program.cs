using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_By_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                for (int j = 0; j < numbers.Length; j++)
                {
                    int secondNum = numbers[j];
                    if (currentNum - secondNum == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
