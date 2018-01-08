using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> losers = new List<int>();

            int attacker = 0;
            int target = 0;
            while (arr.Count > 1)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    int difference = 0;
                    attacker = i;
                    if (arr[i] > arr.Count)
                    {
                        arr[i] = arr[i] % arr.Count;
                        target = arr[i];
                    }
                    else
                    {
                        target = arr.ElementAt(attacker);
                    }
                    if (losers.Contains(attacker))
                    {
                        continue;
                    }
                    difference = Math.Abs(target - attacker);
                    if (difference == 0)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        losers.Add(attacker);
                        continue;
                    }
                    int winner = 0;
                    int loser = 0;
                    if (difference % 2 == 0)
                    {
                        winner = attacker;
                        loser = target;
                        losers.Add(arr.IndexOf(target));
                    }
                    else if (difference / 2 == 0)
                    {
                        winner = arr.IndexOf(target);
                        loser = attacker;
                        losers.Add(attacker);
                    }

                    Console.WriteLine($"{attacker} x {target} -> {winner} wins");
                }
                for (int i = 0; i < losers.Count; i++)
                {
                    arr.RemoveAt(losers[i]);
                }
            }
        }
    }
}
