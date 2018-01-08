using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<string> names = new HashSet<string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            names.Add(input);
        }
        Console.WriteLine();
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}

