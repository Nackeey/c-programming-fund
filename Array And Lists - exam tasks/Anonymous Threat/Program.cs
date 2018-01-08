using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] commands = input.Split();
                string command = commands[0];
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);

                if (startIndex < 0 || startIndex > elements.Count)
                {
                    startIndex = 0;
                }
                if (endIndex >= elements.Count)
                {
                    endIndex = elements.Count - 1;
                }

                switch (command)
                {
                    case "merge":

                        var mergedElements = "";
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            mergedElements += elements[i];
                        }
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            elements.RemoveAt(startIndex);
                        }
                        elements.Insert(startIndex, mergedElements);

                        break;
                    case "divide":
                        int elementToDivide = int.Parse(commands[1]);
                        int partitions = int.Parse(commands[2]);
                        List<string> result = DivideElement(elements[elementToDivide], partitions);
                        elements.RemoveAt(elementToDivide);
                        elements.InsertRange(elementToDivide, result);

                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", elements));
        }
        static List<string> DivideElement(string element, int partitions)
        {
            List<string> result = new List<string>();
            int partitionsCount = element.Length / partitions;

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    result.Add(element.Substring(i * partitionsCount));
                }
                else
                {
                    result.Add(element.Substring(i * partitionsCount, partitionsCount));
                }
            }
            return result;
        }
    }
}
