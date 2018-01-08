using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] firstRow = new int[k * 2];
            int[] secondRow = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = arr[k - i - 1];
                firstRow[firstRow.Length - i - 1] = arr[arr.Length - k + i];
                secondRow[2 * i] = arr[2 * i + k];
                secondRow[2 * i + 1] = arr[2 * i + k + 1];
            }

            int[] result = new int[k * 2];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
