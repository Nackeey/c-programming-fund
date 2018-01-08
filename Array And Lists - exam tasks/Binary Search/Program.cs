using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());
            int linearCounter = 0;

            bool founded = false;
            for (int i = 0; i < arr.Length; i++)
            {
                linearCounter++;
                if (x == arr[i])
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Linear search made {linearCounter} iterations");
                    founded = true;
                    break;
                }
            }

            if (!founded)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Linear search made {linearCounter} iterations");
            }
            Array.Sort(arr);

            int binarycounter = 0;
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                binarycounter++;
                int m = l + ((r - l) / 2);

                if (arr[m] == x)
                {
                    Console.WriteLine($"Binary search made {binarycounter} iterations");

                    return;
                }
                if (arr[m] < x)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            Console.WriteLine($"Binary search made {binarycounter} iterations");
        }
    }
}
