using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;

            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split().ToList();
                string site = data[0];
                totalLoss += decimal.Parse(data[1]) * decimal.Parse(data[2]);
                Console.WriteLine(site);
            }
            BigInteger keyForPrint = BigInteger.Pow(securityKey, n);

            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine("Security Token: " + keyForPrint);
        }
    }
}
