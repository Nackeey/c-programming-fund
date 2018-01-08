using System;
using System.Numerics;


namespace _13.Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactoriel(n));
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
    }
}
