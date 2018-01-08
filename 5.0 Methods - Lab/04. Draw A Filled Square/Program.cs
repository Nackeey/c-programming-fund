using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_A_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintDashes(n);
            for (int i = 1; i <= n - 2; i++)
            {
                PrintMiddleParts(n);
            }
            PrintDashes(n);
        }

        static void PrintDashes(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintMiddleParts(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.Write('-');
            Console.WriteLine();
        }
    }
}
