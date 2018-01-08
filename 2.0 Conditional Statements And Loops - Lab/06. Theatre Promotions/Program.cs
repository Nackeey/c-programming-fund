using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOftheDay = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            var price = 0.0;

            if (typeOftheDay == "weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                }
            }
            if(typeOftheDay == "weekend")
            {
                if((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
            }
            if(typeOftheDay == "holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;

                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }
            if(price != 0)
            {
                Console.WriteLine("{0}$",price);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
