using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                var square = Math.Sqrt(currentNumber);
                if (square == (int)square)
                {
                    Console.Write("{0} ", currentNumber);
                }
            }
        }
    }
}
