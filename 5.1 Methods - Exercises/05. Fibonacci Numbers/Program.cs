using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(number));
        }

        static int Fibonacci(int num)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = 0;
            for (int i = 0; i < num; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;

            }
            return num3;
        }
    }
}
