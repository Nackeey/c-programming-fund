using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var servicePackage = Console.ReadLine();
            string hall = "";
            var priceHall = 0.0;
            var servicePrice = 0.0;
            var discount = 0.0;

            switch (servicePackage)
            {
                case "Normal": servicePrice = 500; discount = 5; break;
                case "Gold": servicePrice = 750; discount = 10; break;
                case "Platinum": servicePrice = 1000; discount = 15; break;
            }

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                priceHall = 2500;
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
                priceHall = 5000;
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                priceHall = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                Environment.Exit(0);
            }
            
                var total = priceHall + servicePrice;
                var priceWithDiscount = total - (total * discount/100);
                var pricePerPerson = priceWithDiscount / groupSize;
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            
        }
    }
}
