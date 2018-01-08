
namespace _03.Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<double> list = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            int i = 0;
            while (i < list.Count - 1)
            {
                if (list[i] == list[i + 1])
                {
                    list[i] += list[i + 1];
                    list.RemoveAt(i + 1);
                    i--;
                    if (i < 0)
                    {
                        i = 0;
                    }
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
