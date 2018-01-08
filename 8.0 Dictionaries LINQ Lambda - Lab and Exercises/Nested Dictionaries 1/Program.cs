using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int grades = int.Parse(Console.ReadLine());
        var dict = new Dictionary<string, List<double>>();

        for (int i = 0; i < grades; i++)
        {
            string[] info = Console.ReadLine().Split(' ');
            string name = info[0];
            double grade = double.Parse(info[1]);

            if (!dict.ContainsKey(name))
            {
                dict.Add(name, new List<double>());
            }
            dict[name].Add(grade);
        }
        foreach (KeyValuePair<string, List<double>> record in dict)
        {
            string name = record.Key;
            List<double> grade = record.Value;
            Console.Write("{0} -> ", name);
            foreach (var item in grade)
            {
                Console.Write("{0:F2} ", item);
            }
            Console.WriteLine("(avg: {0:F2})", grade.Average());
        }
    }
}

