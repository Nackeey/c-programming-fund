using System;

namespace _04.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var toHex = number.ToString("X");
            var toBinary = Convert.ToString(number, 2);

            Console.WriteLine(toHex);
            Console.WriteLine(toBinary);
        }
    }
}
