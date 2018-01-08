using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;

            while(true)
            {
                var input = Console.ReadLine();

                if (input == "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {input}.");
                counter++;                
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
