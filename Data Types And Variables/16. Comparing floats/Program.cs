using System;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var compare = Math.Abs(a - b) < 0.000001;
            Console.WriteLine(compare);
        }
    }
}
