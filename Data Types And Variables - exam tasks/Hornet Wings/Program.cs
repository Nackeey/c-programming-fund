using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = (wingFlaps / 1000)* distanceInMeters;
            double seconds = (wingFlaps / 100);
            double secondsWithRest = (wingFlaps / endurance) * 5;
            double totalSeconds = seconds + secondsWithRest;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalSeconds} s.");
        }
    }
}
