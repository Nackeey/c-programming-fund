using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Divisible_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 3; i <= 100; i+=3)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
