using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Lab_Remove_Negatives_And_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();


            foreach (var number in list)
            {
                if (number >= 0)
                {
                    result.Add(number);
                }
            }
            result.Reverse();
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ",result));
            }
            else
            {
                Console.WriteLine("empty");
            }




            //var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //var newList = new List<int>();
            //int count = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] >= 0)
            //    {
            //        newList.Add(list[i]);
            //    }
            //    if (list[i] < 0)
            //    {
            //        count++;
            //        if (count >= list.Count)
            //        {
            //            Console.WriteLine("empty");
            //        }
            //    }
            //}
            //newList.Reverse();
            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
