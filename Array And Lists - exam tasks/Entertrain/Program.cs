using System;
using System.Collections.Generic;
using System.Linq;

class Entertrain
{
    static void Main()
    {
        int locomotivesPower = int.Parse(Console.ReadLine());
        List<int> wagons = new List<int>();
        var input = Console.ReadLine();

        while (input != "All ofboard!")
        {
            wagons.Add(int.Parse(input));
            if (wagons.Sum() > locomotivesPower)
            {
                int closestWagon = wagons.OrderBy(x => Math.Abs(x - wagons.Average())).First();
                wagons.Remove(closestWagon);
            }
            input = Console.ReadLine();
        }
        wagons.Reverse();
        Console.WriteLine($"{string.Join(" ", wagons)} {locomotivesPower}");
    }
}