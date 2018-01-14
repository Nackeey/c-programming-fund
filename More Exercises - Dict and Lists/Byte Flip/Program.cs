using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageCode = Console.ReadLine()
                .Split(' ')
                .Where(x => x.Length == 2)
                .Select(x => new string(x.Reverse().ToArray()))
                .Select(x => Convert.ToChar(Convert.ToInt32(x, 16)))
                .Reverse()
                .ToList();

            Console.WriteLine(string.Join(null, messageCode));
        }
    }
}
