using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();
            switch(country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Argentina":
                case "Mexico":
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
