using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            short years = (short)(centuries * 100);
            double days = Math.Floor(years * 365.2422);
            int hours = (int)(days * 24);
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }
    }
}
