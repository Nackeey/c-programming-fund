using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distance = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            while (distance.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                var removedElement = 0;

                if (index >= 0 && index < distance.Count)
                {
                    removedElement = distance.ElementAt(index);
                    distance.RemoveAt(index);
                }
                else if (index < 0)
                {
                    removedElement = distance[0];
                    distance[0] = distance[distance.Count -1];
                }
                else if (index > distance.Count - 1)
                {
                    removedElement = distance[distance.Count - 1];
                    distance[distance.Count - 1] = distance[0];
                }

                for (int i = 0; i < distance.Count; i++)
                {
                    if (distance[i] <= removedElement)
                    {
                        distance[i] += removedElement;
                    }
                    else
                    {
                        distance[i] -= removedElement;
                    }
                }
                sum += removedElement;
            }
            Console.WriteLine(sum);
        }
    }
}
