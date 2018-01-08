using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace exercises_02.Convert_From_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int baseN = int.Parse(nums[0]);
            string number = nums[1];

            BigInteger result = 0;

            int power = number.Length - 1;
            for (int i = 0; i < number.Length; i++)
            {
                BigInteger num = BigInteger.Parse(number[i].ToString());
                result += BigInteger.Multiply(num, BigInteger.Pow(baseN, power));
                power--;
            }
            Console.WriteLine(result);
        }
    }
}
