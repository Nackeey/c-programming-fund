using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.List_Of_Decimal_Numbers_Exercise
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            list.Sort();
            Console.WriteLine(string.Join(" <= ", list));
        }
    }
}
