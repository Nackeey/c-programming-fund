using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maps
{
    class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            string result = string.Empty;

            while (true)
            {
                string[] clues = Console.ReadLine().Split(' ');
                char marks = char.Parse(clues[0]);
                int minCount = int.Parse(clues[1]);

                for (int i = 0; i < map.Length; i++)
                {
                    if (map[i] == marks)
                    {
                        sb.Append(map[i]);
                        if (sb.Length > result.Length)
                        {
                            result = sb.ToString();
                        }
                    }
                    else
                    {
                        sb.Clear();
                    }
                }
                if (result.Length >= minCount)
                {
                    break;
                }
            }
            int index = map.IndexOf(result);
            Console.WriteLine($"Hideout found at index {index} and it is with size {result.Length}!");
        }
    }
}
