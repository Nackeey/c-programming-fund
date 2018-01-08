using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<string> text = Console.ReadLine()
            .ToLower()
            .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }
        , StringSplitOptions.RemoveEmptyEntries)
        .ToList();

        var sorted = text.Where(x => x.Length < 5).OrderBy(x => x).Distinct();

        Console.Write(string.Join(", ", sorted));
    }
}

