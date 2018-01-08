using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());

            if (n2 > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", n1, n2, n1 * n2);

            }
            else
            {
                for (int i = n2; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", n1, i, n1 * i);
                }
            }    
        }
       
    }
}
