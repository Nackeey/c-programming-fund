using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int maxOfTwo = GetMaxOfNumbers(firstNumber, secondNumber);
            int maxOfAll = GetMaxOfNumbers(maxOfTwo, thirdNumber);
            Console.WriteLine(maxOfAll);
        }

        static int GetMaxOfNumbers(int first, int second)
        {
            int maxOfTwoNum = Math.Max(first, second);
            return maxOfTwoNum;
        }
    }
}
