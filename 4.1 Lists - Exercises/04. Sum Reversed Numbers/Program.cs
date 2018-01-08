using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Sum_Reversed_Numbers
{
    public class Program
    {
        public static void Main()
        {
            long result = Console.ReadLine()
               .Split()
               .Select(a => int.Parse(new string(a.Reverse().ToArray()))).Sum();
            Console.WriteLine(result);
        }
    }
}
