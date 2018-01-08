using System;
using System.Collections.Generic;
using System.Linq;

class Wardrobe
{
    static void Main()
    {
        var data = new Dictionary<string, Dictionary<string, int>>();

        int clothLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < clothLines; i++)
        {
            string[] inputTokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string color = inputTokens[0];
            string[] clothes = inputTokens[1].Split(',');

            if (!data.ContainsKey(color))
            {
                data.Add(color, new Dictionary<string, int>());
            }
            foreach (string cloth in clothes)
            {
                Dictionary<string, int> clothDb = data[color];
                if (!clothDb.ContainsKey(cloth))
                {
                    clothDb.Add(cloth, 0);
                }
                clothDb[cloth]++;
            }
        }
        string[] searchTokens = Console.ReadLine().Split(' ');
        string searchedColor = searchTokens[0];
        string searchedCloth = searchTokens[1];

        foreach (var colorData in data)
        {
            string color = colorData.Key;
            Dictionary<string, int> clothesData = colorData.Value;
            Console.WriteLine("{0} clothes:", color);

            foreach (var clothData in clothesData)
            {
                string cloth = clothData.Key;
                int quantity = clothData.Value;
                Console.Write("* {0} - {1}", cloth, quantity);

                if (color == searchedColor && cloth == searchedCloth)
                {
                    Console.Write(" (found!)");
                }
                Console.WriteLine();
            }
        }
    }
}

