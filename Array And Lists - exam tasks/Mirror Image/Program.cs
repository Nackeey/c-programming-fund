using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirror_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ');

            string input = Console.ReadLine();
            while (input != "Print")
            {
                int index = int.Parse(input);

                for (int i = 0; i < index / 2; i++)
                {
                    string rem = items[i];
                    items[i] = items[index - i - 1];
                    items[index - i - 1] = rem;
                }
                for (int i = 0; i < (items.Length - index) / 2; i++)
                {
                    string rem = items[index + i + 1];
                    items[index + i + 1] = items[items.Length - i - 1];
                    items[items.Length - i - 1] = rem;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", items));
        }
    }
}
