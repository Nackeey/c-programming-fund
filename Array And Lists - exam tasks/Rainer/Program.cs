using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
        int donaldIndex = sequence[sequence.Last()];
        int counter = 0;

        sequence.RemoveAt(sequence.Count - 1);
        var original = new List<int>();
        original.AddRange(sequence);

        DecreaseAllNumbers(sequence);

        int nextIndex = int.Parse(Console.ReadLine());

        while (true)
        {
            donaldIndex = sequence[nextIndex];
            counter++;

            DecreaseAllNumbers(sequence);

            if (sequence[nextIndex] == 0)
            {
                break;
            }
            ReturnTheOriginalValue(sequence, original);
            nextIndex = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"{string.Join(" ", sequence)}");
        Console.WriteLine(counter);
    }

    private static void ReturnTheOriginalValue(List<int> sequence, List<int> original)
    {
        for (int i = 0; i < sequence.Count; i++)
        {
            if (sequence[i] == 0)
            {
                sequence[i] = original[i];
            }
        }
    }

    private static void DecreaseAllNumbers(List<int> sequence)
    {
        for (int i = 0; i < sequence.Count; i++)
        {
            sequence[i] -= 1;
        }
    }
}