using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();

            var data = new Dictionary<string, int>();
            foreach (var word in arr)
            {
                if (!data.ContainsKey(word))
                {
                    data.Add(word, 1);
                }
                else
                {
                    data[word] += 1;
                }
            }
            foreach (var item in data.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times ({100 * item.Value / (double)arr.Count():f2}%)");
            }
        }
    }
}
