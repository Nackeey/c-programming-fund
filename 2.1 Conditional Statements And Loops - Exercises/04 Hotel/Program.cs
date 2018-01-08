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
            var priceDouble = 0;
            var priceSuite = 0;

            switch (month)
            {
                
                case "June":
                case "September": priceStudio = 60; priceDouble = 72; priceSuite = 82; break;
                case "July":
                case "August":
                case "December":
                    priceStudio = 68; priceDouble = 77; priceSuite = 89; break;


                    if (month == "May")
                    {
                        priceStudio = 50;
                        priceSuite = 75;
                        if (nights > 7)
                        {
                            priceStudio -= priceStudio * 0.95;
                        }
                    }
                    else if (month == "October")
                    {
                        priceSuite = 75;
                        priceDouble = 65;
                        if (nights  > 7)
                        {
                            priceStudio *= 0.95;
                            nights -= 1;
                        }
                    }
                    else if (month == "June" && nights > 14)
                    {
                        priceDouble -= priceDouble * 0.10;
                    }
                    else if (month == "September" && nights > 14)
                    {
                        priceDouble -= priceDouble * 0.10;
                        nights -= 1;
                    }
                    else if (month == "July" || month == "August" || month == "December" && nights > 14)
                    {
                        priceSuite -= priceSuite * 0.15;
                    }
                    Console.WriteLine("Studio: {0:F2} lv.", priceStudio * nights);
                    Console.WriteLine($"Double: {priceDouble * nights:F2} lv.");
                    Console.WriteLine($"Suite: {priceSuite * nights:F2} lv.");
            }
        }
    }
}
