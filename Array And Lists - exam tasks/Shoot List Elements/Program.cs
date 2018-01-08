using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = new List<int>();
            int lastRemovedElement = 0;

            string input = Console.ReadLine();
            while (true)
            {
                if (input == "stop")
                {
                    if (elements.Count == 0)
                    {
                        Console.WriteLine($"you shot them all. last one was {lastRemovedElement}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"survivors: {string.Join(", ", elements)}");
                    }
                    
                }
                else if (input == "bang" && elements.Count == 0)
                {
                    Console.WriteLine($"nobody left to shoot! last one was {lastRemovedElement}");
                    return;
                }
                if (input != "bang")
                {
                    elements.Insert(0, (int.Parse(input)));
                }
                else if (input == "bang")
                {
                    double average = elements.Average();
                    if (elements.Count == 1)
                    {
                        lastRemovedElement = elements[0];
                        elements.Remove(lastRemovedElement);
                        Console.WriteLine($"shot {lastRemovedElement}");
                    }
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] == 0)
                        {
                            elements.Remove(elements[i]);
                        }
                        
                        if (elements[i] < average)
                        {
                            lastRemovedElement = elements[i];
                            elements.Remove(elements[i]);
                            Console.WriteLine($"shot {lastRemovedElement}");
                           
                            break;
                        }
                    }
                    for (int j = 0; j < elements.Count; j++)
                    {
                        elements[j] -= 1;
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
