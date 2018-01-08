using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                var dwarfInfo = input.Split("<:> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                string color = dwarfInfo[1];
                string name = dwarfInfo[0];
                int physics = int.Parse(dwarfInfo[2]);

                if (name.Contains(':') || name.Contains('<') || name.Contains('>') || name.Contains(' '))
                {
                    continue;
                }
                if (color.Contains(':') || color.Contains('<') || color.Contains('>') || color.Contains(' '))
                {
                    continue;
                }
                if (!data.ContainsKey(color))
                {
                    data.Add(color, new Dictionary<string, int>());
                    data[color][name] = physics;
                }
                else if (!data[color].ContainsKey(name))
                {
                    data[color].Add(name, physics);
                }
                if (data[color][name] < physics)
                {
                    data[color][name] = physics;
                }
                input = Console.ReadLine();
            }

            foreach (var color in data.OrderByDescending(x => x.Value.Values.Max()))
            {
                foreach (var dwarf in color.Value)
                {
                    Console.Write($"({color.Key}) ");
                    Console.WriteLine($"{dwarf.Key} <-> {dwarf.Value}");
                }
            }
        }
    }
}
