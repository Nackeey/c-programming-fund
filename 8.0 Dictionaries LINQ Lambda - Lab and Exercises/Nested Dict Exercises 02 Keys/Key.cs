using System;
using System.Collections.Generic;
using System.Linq;

class Key
{
    static void Main()
    {
        var data = new Dictionary<string, List<string>>();

        string searchedKey = Console.ReadLine();
        string searchedValue = Console.ReadLine();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] text = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
            string key = text[0];
            string[] value = text[1].Split(';');

            if (key.Contains(searchedKey))
            {
                if (!data.ContainsKey(key))
                {
                    data.Add(key, new List<string>());
                    foreach (var word in value)
                    {
                        if (word.Contains(searchedValue))
                        {
                            data[key].Add(word);
                        }
                    }
                }
            }
        }
        foreach (var keyName in data)
        {
            string keys = keyName.Key;
            List<string> values = keyName.Value;
            Console.WriteLine("{0}:", keys);
            foreach (var word in values)
            {
                Console.WriteLine("-{0}", word);
            }
        }
    }
}

