using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factoriel = GetFactoriel(number);
            Console.WriteLine(CountTheZeroes(factoriel));
        }

        static BigInteger GetFactoriel(int n)
        {
            BigInteger factoriel = 1;
            for (int i = n; i > 0; i--)
            {
                factoriel *= i;
            }
            return factoriel;
        }

        static BigInteger CountTheZeroes(BigInteger fact)
        {
            int zeroes = 0;
            while (fact % 10 == 0)
            {
                zeroes++;
                fact /= 10;
            }
            return zeroes;
        }
    }
}
