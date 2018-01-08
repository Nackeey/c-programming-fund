using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] players = Console.ReadLine().Split();

            for (int i = 0; i < players.Length; i++)
            {
                var topens = players[i].Split(',');
                int power = int.Parse(topens[0]);
                string direction = topens[1];
                int bullet = Array.IndexOf(arr, 1);

                switch (direction)
                {
                    case "Right":

                        for (int j = 0; j < power; j++)
                        {
                            RightRotation(arr);
                        }
                        if (arr[2] == 1)  
                        {
                            Console.WriteLine($"Game over! Player {i} is dead.");
                            return;
                        }
                        break;

                    case "Left":

                        for (int j = 0; j < power; j++)
                        {
                            for (int k = 0; k < arr.Length - 1; k++)
                            {
                                int rem = arr[k + 1];
                                arr[k + 1] = arr[k];
                                arr[k] = rem;
                            }
                        }
                        if (arr[2] == 1)
                        {
                            Console.WriteLine($"Game over! Player {i} is dead.");
                            return;
                        }
                        break;
                }

                RightRotation(arr);
            }
            Console.WriteLine("Everybody got lucky!");
        }

        private static void RightRotation(int[] arr)
        {
            for (int p = arr.Length - 1; p > 0; p--)
            {
                int rem = arr[p];
                arr[p] = arr[p - 1];
                arr[p - 1] = rem;
            }
        }
    }
}
