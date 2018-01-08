using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_An_Array_Of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            for (int j = arr.Length - 1; j >= 0; j--)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}
