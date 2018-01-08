using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                long hornetsPower = hornets.Sum();

                if (hornets.Count == 0)
                {
                    break;
                }
                if (beehives[i] >= hornetsPower)
                {
                    beehives[i] -= hornetsPower;
                    hornets.RemoveAt(0);
                }
                else
                {
                    beehives[i] = 0;
                }
            }
            if (beehives.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets.Where(x => x > 0)));
            }
        }
    }
}
