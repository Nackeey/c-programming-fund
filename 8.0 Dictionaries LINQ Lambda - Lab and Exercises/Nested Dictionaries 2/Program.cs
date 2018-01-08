using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            string[] words = Console.ReadLine().Split(' ');
            string continent = words[0];
            string country = words[1];
            string city = words[2];

            if (!continentsData.ContainsKey(continent))
            {
                continentsData.Add(continent, new SortedDictionary<string, SortedSet<string>>()); 
            }
            if (!continentsData[continent].ContainsKey(country))
            {
                continentsData[continent].Add(country, new SortedSet<string>());
            }
            continentsData[continent][country].Add(city);
        }
        foreach (var continentData in continentsData)
        {
            var continent = continentData.Key;
            var countrisData = continentData.Value;
            Console.WriteLine("{0}:", continent);
            foreach (var countries in countrisData)
            {
                var country = countries.Key;
                var city = countries.Value;
                Console.WriteLine("{0} -> {1}", country, string.Join(", ", city));
            }
        }
    }
}
