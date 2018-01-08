using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            var plane = Console.ReadLine().Split().Select(int.Parse).ToList();
            int startIndex = int.Parse(Console.ReadLine());
            int icarusDamage = 1;

            string input = Console.ReadLine();

            while (input != "Supernova")
            {
                string[] moves = input.Split().ToArray();
                string direction = moves[0];
                int steps = int.Parse(moves[1]);

                if (direction == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startIndex == 0 && steps > i)
                        {
                            startIndex = plane.Count - 1;
                            icarusDamage++;
                            plane[startIndex] -= icarusDamage;
                        }
                        else
                        {
                            plane[startIndex - 1] -= icarusDamage;
                            startIndex--;
                        }
                    }
                }

                if (direction == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startIndex == plane.Count - 1 && steps > i)
                        {
                            startIndex = 0;
                            icarusDamage++;
                            plane[startIndex] -= icarusDamage;
                        }
                        else
                        {
                            plane[startIndex + 1] -= icarusDamage;
                            startIndex++;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
