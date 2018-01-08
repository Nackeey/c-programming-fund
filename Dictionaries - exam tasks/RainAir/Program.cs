using System;
using System.Collections.Generic;
using System.Linq;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFlights = Console.ReadLine();
            var data = new Dictionary<string, List<int>>();

            while (inputFlights != "I believe I can fly!")
            {
                if (!inputFlights.Contains('='))
                {
                    AddCustomerAndFlights(inputFlights, data);
                }
                else
                {
                    var names = inputFlights.Split("= ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    data[names[0]] = new List<int>(data[names[1]]);
                }

                inputFlights = Console.ReadLine();
            }

            PrintResult(data);
        }

        private static void PrintResult(Dictionary<string, List<int>> data)
        {
            foreach (var item in data.OrderByDescending(x => x.Value.Count()).ThenBy(e => e.Key))
            {
                var customer = item.Key;
                Console.Write($"#{customer} ::: ");

                Console.WriteLine($"{string.Join(", ", item.Value.OrderByDescending(x => x).Reverse())}");
            }
        }

        private static Dictionary<string, List<int>> AddCustomerAndFlights(string inputFlights, Dictionary<string, List<int>> info)
        {
            var tokens = inputFlights.Split().ToList();
            var customerName = tokens[0];
            tokens.RemoveAt(0);

            if (!info.ContainsKey(customerName))
            {
                info.Add(customerName, new List<int>());
            }
            foreach (var item in tokens)
            {
                info[customerName].Add(int.Parse(item));
            }
            return info;
        }
    }
}
