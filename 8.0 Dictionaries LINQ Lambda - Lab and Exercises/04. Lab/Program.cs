using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        var sorted = nums.OrderByDescending(x => x).Take(3);
        Console.Write(string.Join(" ", sorted));
        Console.WriteLine();
    }
}

