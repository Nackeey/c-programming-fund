using System;

namespace _02._Sigh_of_Integer_Number
{
    class Program
    {

        static void PrintSigh(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {0} is zero.");
            }
        }
        static void Main(string[] args)
        {
            PrintSigh(int.Parse(Console.ReadLine()));
        }
    }
}
