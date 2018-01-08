using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Search_for_a_Number
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var commandArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = numbers.Take(commandArgs[0]).ToList();
            result.RemoveRange(0, commandArgs[1]);

            Console.WriteLine(result.Contains(commandArgs[2]) ? "YES!" : "NO!");
        }
    }
}
