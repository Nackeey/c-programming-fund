using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var calories = 0;

            for (int i = 1; i <= n; i++)
            {
                var lines = Console.ReadLine().ToLower();
                

                if (lines == "cheese")
                {
                    calories += 500;
                }
                else if (lines == "tomato sauce")
                {
                    calories += 150;
                }
                else if(lines == "salami")
                {
                    calories += 600;
                }
                else if (lines == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
