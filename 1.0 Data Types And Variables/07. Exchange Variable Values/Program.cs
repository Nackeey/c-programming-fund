using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c = a;
            a = b;
            
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {c}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {b}");
            Console.WriteLine($"b = {c}");

        }
    }
}
