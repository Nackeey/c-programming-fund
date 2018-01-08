using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int factorY = int.Parse(Console.ReadLine());

            int percent = (pokePower * 50) / 100;
            int count = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                count++;

                if (pokePower == percent)
                {
                    if (factorY > 0)
                    {
                        pokePower /= factorY;
                    }
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}

