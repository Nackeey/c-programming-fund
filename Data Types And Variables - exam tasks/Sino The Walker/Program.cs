using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine().Split(':').ToArray();
            BigInteger steps = BigInteger.Parse(Console.ReadLine());
            BigInteger timeForEachStep = BigInteger.Parse(Console.ReadLine());

            int hours = int.Parse(time[0]) * 3600;
            int minutes = int.Parse(time[1]) * 60;
            int seconds = int.Parse(time[2]);

            int totalTime = hours + minutes + seconds;

            BigInteger totalInSeconds = totalTime + (steps * timeForEachStep);
            BigInteger arriveHour = (totalInSeconds / 3600) % 24;
            BigInteger arriveMinutes = (totalInSeconds / 60) % 60;
            BigInteger arriveSeconds = totalInSeconds % 60;

            Console.WriteLine($"Time Arrival: {arriveHour:00}:{arriveMinutes:00}:{arriveSeconds:00}");
        }
    }
}
