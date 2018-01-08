using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long snowballValue = 0;
            BigInteger bestValue = 0;
            BigInteger currentValue = 0;

            BigInteger bestSnowballTime = 0;
            BigInteger bestSnowballSnow = 0;
            BigInteger bestSnowballQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = snowballSnow / snowballTime;
                currentValue = BigInteger.Pow(snowballValue, snowballQuality);
                if (currentValue > bestValue)
                {
                    bestValue = currentValue;
                    bestSnowballTime = snowballTime;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestValue} ({bestSnowballQuality})");

        }
    }
}
