using System;

namespace _18.Different_Integer_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            var longParse = true;
            var uintParse = true;
            var intParse = true;
            var ushortParse = true;
            var shortParse = true;
            var byteParse = true;
            var sbyteParse = true;

            var isParsed = false;

            try
            {
                var longParsed = long.Parse(number);
                isParsed = true;
            }
            catch (Exception)
            {
                longParse = false;
            }
            try
            {
                var uintParsed = uint.Parse(number);
                isParsed = true;
            }
            catch (Exception)
            {
                uintParse = false;
            }
            try
            {
                var intParsed = int.Parse(number);
                isParsed = true;
            }
            catch (Exception)
            {
                intParse = false;
            }
            try
            {
                var ushortParsed = ushort.Parse(number);
                isParsed = true;
            }
            catch (Exception)
            {
                ushortParse = false;
            }
            try
            {
                var shortParsed = short.Parse(number);
                isParsed = true;
            }
            catch (Exception)
            {
                shortParse = false;
            }
            try
            {
                var byteParsed = byte.Parse(number);
                isParsed = true;
            }
            catch (Exception)
            {
                byteParse = false;
            }
            try
            {
                var sbyteParsed = sbyte.Parse(number);
                isParsed = true;
            }
            catch (Exception)
            {
                sbyteParse = false;
            }

            if (isParsed)
            {
                Console.WriteLine($"{number} can fit in:");
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }

            if (sbyteParse)
            {
                Console.WriteLine("* sbyte");
            }
            if (byteParse)
            {
                Console.WriteLine("* byte");
            }
            if (shortParse)
            {
                Console.WriteLine("* short");
            }
            if (ushortParse)
            {
                Console.WriteLine("* ushort");
            }
            if (intParse)
            {
                Console.WriteLine("* int");
            }
            if (uintParse)
            {
                Console.WriteLine("* uint");
            }
            if (longParse)
            {
                Console.WriteLine("* long");
            }
        }
    }
}
