using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_Of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            if (value == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (value == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine((char)GetMax(first, second));
            }
            else
            {
                string textOne = Console.ReadLine();
                string textTwo = Console.ReadLine();
                Console.WriteLine(GetMax(textOne, textTwo));
            }
        }

        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        static string GetMax(string textOne, string textTwo)
        { 
            if (textOne.CompareTo(textTwo) >= 0)
            {
                return textOne;
            }
            else
            {
                return textTwo;
            }
        }
    }
}
