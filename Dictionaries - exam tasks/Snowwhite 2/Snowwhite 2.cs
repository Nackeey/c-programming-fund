using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowwhite_2 // 70/100points
{
    public class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }

        public Dwarf(string name, string color, int physics)
        {
            Name = name;
            Color = color;
            Physics = physics;
        }
    }

    class Snowwhite_2
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                string[] dwarfInfo = input.Split("<:> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string color = dwarfInfo[1];
                string name = dwarfInfo[0];
                int physics = int.Parse(dwarfInfo[2]);

                if (dwarfs.Any(d => d.Color == color))
                {
                    Dwarf sameDwarf = dwarfs.First(d => d.Color == color);
                    if (sameDwarf.Name == name)
                    {
                        if (physics > sameDwarf.Physics)
                        {
                            sameDwarf.Physics = physics;
                        }
                    }
                    else
                    {
                        Dwarf dwarf = new Dwarf(name, color, physics);
                        dwarfs.Add(dwarf);
                    }
                }
                else
                {
                    Dwarf dwarf = new Dwarf(name, color, physics);
                    dwarfs.Add(dwarf);
                }

                input = Console.ReadLine();
            }

            foreach (var dwarf in dwarfs.OrderByDescending(p => p.Physics))
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}