using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, List<string>> database = new Dictionary<string, List<string>>();

        while (input != "Blaze it!")
        {
            string[] data = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string creature = data[0];
            string squadMate = data[1];

            if (creature != squadMate)
            {
                if (!database.ContainsKey(creature))
                {
                    database.Add(creature, new List<string>());
                }
                if (!database[creature].Contains(squadMate))
                {
                    database[creature].Add(squadMate);
                }
            }

            input = Console.ReadLine();
        }

        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

        foreach (KeyValuePair<string, List<string>> item in database)
        {
            result.Add(item.Key, new List<string>());

            foreach (string mate in item.Value)
            {
                if (database.ContainsKey(mate) && database[mate].Contains(item.Key))
                {
                    continue;
                }
                else
                {
                    result[item.Key].Add(mate);
                }
            }
        }
        foreach (var item in result.OrderByDescending(x => x.Value.Count()))
        {
            Console.WriteLine($"{item.Key} : {item.Value.Count()}");
        }
    }
}

