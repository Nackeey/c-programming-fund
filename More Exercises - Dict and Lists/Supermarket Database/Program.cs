using System;
using System.Collections.Generic;

namespace Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<double>>();
            double total = 0;

            string input = Console.ReadLine();

            while (input != "stocked")
            {
                string[] tokens = input.Split();
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                double quantity = double.Parse(tokens[2]);

                if (!data.ContainsKey(product))
                {
                    data.Add(product, new List<double>());
                    data[product].Add(price);
                    data[product].Add(quantity);
                }
                else
                {
                    data[product][0] = price;
                    data[product][1] += quantity;
                }

                input = Console.ReadLine();
            }
            foreach (var drink in data)
            {
                var items = drink.Value;
                var quantity = items[1];
                var price = items[0];
                var sum = price * quantity;
                total += sum;

                Console.WriteLine($"{drink.Key}: ${price:f2} * {quantity} = ${sum:f2}");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${total:f2}");
        }
    }
}
