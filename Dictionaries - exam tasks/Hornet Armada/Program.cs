using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, Dictionary<string, long>> legionsInfo = new Dictionary<string, Dictionary<string, long>>();
        Dictionary<string, long> legionsActivity = new Dictionary<string, long>();

        for (int i = 0; i < n; i++)
        {
            string[] info = Console.ReadLine().Split("=->: ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string legionName = info[1];
            string soldierType = info[2];
            long lastActivity = long.Parse(info[0]);
            long soldierCount = long.Parse(info[3]);

            if (!legionsInfo.ContainsKey(legionName))
            {
                legionsInfo.Add(legionName, new Dictionary<string, long>());
                legionsActivity.Add(legionName, lastActivity);
            }
            if (!legionsInfo[legionName].ContainsKey(soldierType))
            {
                legionsInfo[legionName].Add(soldierType, soldierCount);
            }
            else
            {
                legionsInfo[legionName][soldierType] += soldierCount;
            }
            if (legionsActivity[legionName] < lastActivity)
            {
                legionsActivity[legionName] = lastActivity;
            }
        }
        string command = Console.ReadLine();
        if (command.IndexOf('\\') != -1)
        {
            long activity = long.Parse(command.Substring(0, command.IndexOf('\\')));
            string soldier = command.Substring(command.IndexOf('\\') + 1);

            foreach (var item in legionsInfo.Where(e => legionsInfo[e.Key].ContainsKey(soldier))
                .OrderByDescending(k => k.Value[soldier]))
            {
                if (legionsActivity[item.Key] < activity)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value[soldier]}");
                }
            }
        }
        else
        {
            foreach (var item in legionsActivity.OrderByDescending(e => e.Value))
            {
                if (legionsInfo[item.Key].ContainsKey(command))
                {
                    Console.WriteLine($"{item.Value} : {item.Key}");
                }
            }
        }
    }
}
