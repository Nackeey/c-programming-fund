using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            double wormsLength = double.Parse(Console.ReadLine());
            double wormsWidth = double.Parse(Console.ReadLine());

            double lengthInCentimeters = wormsLength * 100;
            double reminder = lengthInCentimeters % wormsWidth;

            if (reminder == 0 || wormsWidth == 0)
            {
                Console.WriteLine("{0:f2}", wormsWidth * lengthInCentimeters);
            }
            else
            {
                Console.WriteLine("{0:f2}%", (lengthInCentimeters / wormsWidth) * 100);
            }
        }
    }
}
