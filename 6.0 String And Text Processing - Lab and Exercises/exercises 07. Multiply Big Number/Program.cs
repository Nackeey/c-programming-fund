using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_07.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();  //60/100pts.
            int num = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();
            int reminder = 0;
            int add = 0;
            int tempResult = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                var augment = Convert.ToInt32(number.Substring(i, 1));
                tempResult = augment * num;
                add = tempResult % 10 + reminder;
                reminder = tempResult / 10;
                if (add > 9)
                {
                    add = add % 10 ;
                    reminder += (add / 10) + 1;
                }
                result.Add(add);
            }
            if (reminder > 0)
            {
                result.Add(reminder);
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
