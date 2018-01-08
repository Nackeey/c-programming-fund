using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isMaster = false;
            for (int i = 1; i <= number; i++)
            {
                if (CheckIsPalindrome(i) && (CheckDivisible(i) && (CheckForEvenDigit(i))))
                {
                    isMaster = true;
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckIsPalindrome(int n)
        {
            bool isPalindrome = false;
            int r = 0;
            int left = n;
            int rev = 0;
            while (left > 0)
            {
                r = left % 10;
                rev = rev * 10 + r;
                left /= 10;
            }
            if (rev == n)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }

        static bool CheckDivisible(int n)
        {
            bool isDivisibleBySeven = false;
            int digit = 0;
            int sum = 0;
            while (n > 0)
            {
                digit = n % 10;
                n /= 10;
                sum += digit;
            }
            if (sum % 7 == 0)
            {
                isDivisibleBySeven = true;
            }
            return isDivisibleBySeven;
        }

        static bool CheckForEvenDigit(int n)
        {
            bool atLeastOneEven = false;
            int digit = 0;
            while (n > 0)
            {
                digit = n % 10;
                if (digit % 2 == 0)
                {
                    atLeastOneEven = true;
                    break;
                }
                else
                {
                    n /= 10;
                }
            }
            return atLeastOneEven;
        }
    }
}
