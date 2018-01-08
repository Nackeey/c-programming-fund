using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements_and_Loops___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());       
            string drink = "";
            var price = 0.0;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    price = 1.00;
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    price = 1.70;
                    break;
                default:
                    drink = "Tea";
                    price = 1.20;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {quantity*price:F2}.");
        }
    }
}
