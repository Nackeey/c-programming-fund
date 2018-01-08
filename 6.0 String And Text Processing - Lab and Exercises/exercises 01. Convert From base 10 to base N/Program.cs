using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace exercises_01.Convert_From_base_10_to_base_N
{
    class Program
    {
        static void Main()
        {
            BigInteger[] nums = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger baseN = nums[0];
            BigInteger base10 = nums[1];
            string result = string.Empty;

            while (base10 > 0)
            {
                BigInteger lastDigit = base10 % baseN;
                base10 = base10 / baseN;
                result += lastDigit.ToString();
            }
            Console.WriteLine(string.Join("", result.Reverse()));
        }
    }
}
