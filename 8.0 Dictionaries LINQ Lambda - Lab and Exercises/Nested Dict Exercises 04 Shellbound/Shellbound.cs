using System;
using System.Collections.Generic;
using System.Linq;

class Shellbound
{
    static void Main()
    {
        Dictionary<string, HashSet<int>> data = new Dictionary<string, HashSet<int>>();
        string[] input = Console.ReadLine().Split(' ');

        while (input[0] != "Aggregate")
        {
            string region = input[0];
            int shellSize = int.Parse(input[1]);

            if (!data.ContainsKey(region))
            {
                data.Add(region, new HashSet<int>());
            }
            data[region].Add(shellSize);
            input = Console.ReadLine().Split(' ');
        }
        foreach (var shellData in data)
        {
            string city = shellData.Key;
            HashSet<int> shellSizeData = shellData.Value;
            Console.WriteLine("{0} -> {1} ({2})", city, string.Join(", ", shellSizeData), GiantShell(shellSizeData));
        }
    }
    static int GiantShell(HashSet<int> average)
    {
        int total = average.Sum() - (average.Sum() / average.Count());
        return total;
    }
}

