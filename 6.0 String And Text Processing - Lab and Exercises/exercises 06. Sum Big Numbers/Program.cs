using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_06.Sum_Big_Numbers
{
    class Program
    {
        static void Main()
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            var result = string.Empty;
            var carry = false;
            int pad = Math.Max(firstNum.Length, secondNum.Length);

            if (firstNum.Length != secondNum.Length)
            {
                firstNum = firstNum.PadLeft(pad, '0');
                secondNum = secondNum.PadLeft(pad, '0');
            }
            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                var augend = Convert.ToInt32(firstNum.Substring(i, 1));
                var addend = Convert.ToInt32(secondNum.Substring(i, 1));
                var sum = augend + addend;
                sum += (carry ? 1 : 0);
                carry = false;
                if (sum > 9)
                {
                    carry = true;
                    sum -= 10;
                }
                result = sum.ToString() + result;
            }
            if (carry)
            {
                result = "1" + result;
            }
            Console.WriteLine(result);
        }
    }
}
