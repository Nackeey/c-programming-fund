using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                BigInteger bodyLength = BigInteger.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                int lengthOfWing = int.Parse(Console.ReadLine());

                decimal total = totalWidth + (2 * lengthOfWing);
                BigInteger phoenix = BigInteger.Pow(bodyLength, 2);
                decimal result = (decimal)phoenix * total;

                Console.WriteLine(result);
            }
        }
    }
}
