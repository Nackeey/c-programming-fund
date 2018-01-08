using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicalNumber = int.Parse(Console.ReadLine());

            var combinations = 0;

            for (int i = n; i <= m; i++)
            {
                for (int k = n; k <= m; k++)
                {
                    combinations++;
                    if (k > i && k + i == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {k} + {i} = {magicalNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");
        }
    }
}
