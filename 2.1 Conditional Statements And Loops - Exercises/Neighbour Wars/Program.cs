using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var PeshosDamage = int.Parse(Console.ReadLine());
            var GoshosDamage = int.Parse(Console.ReadLine());

            var goshosHealth = 100;
            var peshosHealth = 100;
            var roundCounter = 0;

            while (goshosHealth > 0 && peshosHealth > 0)
            {
                roundCounter++;
                if (roundCounter % 2 != 0)
                {
                    goshosHealth -= PeshosDamage;
                    if (goshosHealth < 1)
                    {
                        Console.WriteLine($"Pesho won in {roundCounter}th round.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                    }
                }
                else
                {
                    peshosHealth -= GoshosDamage;
                    if (peshosHealth < 1)
                    {
                        Console.WriteLine($"Gosho won in {roundCounter}th round.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                    }
                }
                if (roundCounter % 3 == 0)
                {
                    goshosHealth += 10;
                    peshosHealth += 10;
                }
            }
        }
    }
}

