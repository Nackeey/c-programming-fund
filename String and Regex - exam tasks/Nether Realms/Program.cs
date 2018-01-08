using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexHp = @"[^\d\.\*\-\+\/]";
            string regexDamage = @"[-+]?\d+(?:\.\d+)?";

            var demons = Console.ReadLine()
                .Split(new [] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(a => a)
                .ToList();
             
            foreach (var demon in demons)
            {
                int health = 0;
                Regex regexHealth = new Regex(regexHp);
                MatchCollection symbolsHealth = regexHealth.Matches(demon);
                foreach (Match item in symbolsHealth)
                {
                    health += item.Value[0];
                }
                double damage = 0;
                MatchCollection symbolsDamage = Regex.Matches(demon, regexDamage);
                foreach (Match s in symbolsDamage)
                {
                    damage += double.Parse(s.Value);
                }

                var multipl = demon.Where(a => a == '*');
                damage *= Math.Pow(2, multipl.Count());
                var divide = demon.Where(a => a == '/');
                damage /= Math.Pow(2, divide.Count());

                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");
            }
        }
    }
}
