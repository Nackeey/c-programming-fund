using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main() 
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        var counts = new SortedDictionary<double, int>();
        foreach (var num in numbers)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }
        foreach (var num in counts)
        {
            Console.WriteLine("{0} -> {1}", num.Key, num.Value);
        }
    }
}

