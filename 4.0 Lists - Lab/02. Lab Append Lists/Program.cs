using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Lab_Append_Lists
{
    public class Program
    {
        public static void Main()
        {
            string[] lists = Console.ReadLine().Split('|');
            List<int> result = new List<int>();

            for (int i = lists.Length - 1; i >= 0; i--)
            {
                int[] numbers = lists[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                result.AddRange(numbers);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
