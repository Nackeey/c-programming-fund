using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            if (number == 1 || number == 0)
            {
                Console.WriteLine(false);
                return;
            }
                Console.WriteLine(CheckIfNumberIsPrime(number));
        }

        static bool CheckIfNumberIsPrime(long n)
        {
            int i = 0;
            var isPrime = true;
            for (i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
