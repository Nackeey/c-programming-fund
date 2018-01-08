using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var priceStudio = 0.0;
            var priceDouble = 0.0;
            var priceSuite = 0.0;

            if (month == "May" || month == "October")
            {
                priceStudio = nights > 7 ? 47.5 : 50;
                priceDouble = 65;
                priceSuite = 75;
                
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 60;
                priceDouble = nights > 14 ? 64.8 : 72;
                priceSuite = 82;
                    
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                priceStudio = 68;
                priceDouble = 77;
                priceSuite = nights > 14 ? 75.65 : 89;
            }
            var totalStudio = priceStudio * nights;
            var totalDouble = priceDouble * nights;
            var totalSuite = priceSuite * nights;

            if (nights > 7 && (month == "September" || month == "October"))
            {
                totalStudio -= priceStudio;
            }

            Console.WriteLine("Studio: {0:F2} lv.", totalStudio);
            Console.WriteLine($"Double: {totalDouble:F2} lv.");
            Console.WriteLine($"Suite: {totalSuite:F2} lv.");
        }
    }
}
