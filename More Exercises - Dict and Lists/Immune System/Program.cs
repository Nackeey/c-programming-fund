using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());
            HashSet<string> viruses = new HashSet<string>();
            double currentHealth = initialHealth;

            string virus = Console.ReadLine();
            while (virus != "end")
            {
                int virusStrength = 0;

                for (int i = 0; i < virus.Length; i++)
                {
                    virusStrength += virus[i];
                }
                virusStrength /= 3;

                int timeToDefeat = 0;

                if (viruses.Contains(virus))
                {
                    timeToDefeat = (virusStrength * virus.Length) / 3;
                }
                else
                {
                    timeToDefeat = virusStrength * virus.Length;
                }

                if (currentHealth < timeToDefeat)
                {
                    Console.WriteLine($"Virus {virus}: {virusStrength} => {timeToDefeat} seconds");
                    Console.WriteLine($"Immune System Defeated.");
                    return;
                }
                string time = string.Format("{0}m {1:0}s.", (timeToDefeat / 60), timeToDefeat % 60);

                currentHealth = Math.Floor(currentHealth - timeToDefeat);

                Console.WriteLine($"Virus {virus}: {virusStrength} => {timeToDefeat} seconds");
                Console.WriteLine($"{virus} defeated in {time}");
                Console.WriteLine($"Remaining health: {Math.Floor(currentHealth)}");

                currentHealth += (currentHealth * 0.20);
                if (currentHealth > initialHealth)
                {
                    currentHealth = initialHealth;
                }
                viruses.Add(virus);
                virus = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: {Math.Floor(currentHealth)}");
        }
    }
}
