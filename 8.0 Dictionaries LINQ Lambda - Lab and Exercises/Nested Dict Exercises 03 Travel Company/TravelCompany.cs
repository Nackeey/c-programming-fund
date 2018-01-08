using System;
using System.Collections.Generic;
using System.Linq;

class TravelCompany
{
    static Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
    static void Main()
    {
        TravelData();
        Accommodation();
    }
    static void TravelData()
    {
        string[] input = Console.ReadLine().Split(':');
        while (input[0] != "ready")
        {
            string city = input[0];
            string capacityData = input[1];
            StoreBusesData(city, capacityData);
            input = Console.ReadLine().Split(':');
        }
    }
    static void StoreBusesData(string city, string input)
    {
        string[] busesData = input.Split(',');
        foreach (var busData in busesData)
        {
            string[] busDataTokens = busData.Split('-');
            string bus = busDataTokens[0];
            int capacity = int.Parse(busDataTokens[1]);

            if (!data.ContainsKey(city))
            {
                data.Add(city, new Dictionary<string, int>());
            }
            data[city][bus] = capacity;
        }
    }
    static void Accommodation()
    {
        string[] input = Console.ReadLine().Split(' ');
        while (input[0] != "travel")
        {
            string destination = input[0];
            int passengers = int.Parse(input[1]);
            Dictionary<string, int> busesData = data[destination];
            ProcessAccommodation(busesData, destination, passengers);

            input = Console.ReadLine().Split(' ');
        }
    }
    static void ProcessAccommodation(Dictionary<string, int> busesData,
        string destination,
        int passengers)
    {
        int availableAccommodation = busesData.Select(kvp => kvp.Value).Sum();
        if (availableAccommodation >= passengers)
        {
            Console.WriteLine("{0} -> all {1} accommodated", destination, passengers);
        }
        else
        {
            Console.WriteLine("{0} -> all except {1} accommodated", destination, passengers - availableAccommodation);
        }
    }
}
