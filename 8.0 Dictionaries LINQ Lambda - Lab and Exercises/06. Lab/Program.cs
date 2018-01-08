using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var k = nums.Length / 4;

        var leftPart = nums.Take(k).Reverse().ToArray();
        var midPart = nums.Skip(k).Take(k * 2).ToArray();
        var rightPart = nums.Skip(k * 3).Take(k).Reverse().ToArray();

        var upperArr = new double[leftPart.Length + rightPart.Length];

        leftPart.CopyTo(upperArr, 0);
        rightPart.CopyTo(upperArr, leftPart.Length);

        var sumTwoArrays = upperArr.Select((x, index) => x + midPart[index]);
            
        //var result = new double[upperArr.Length];   
        //for (int i = 0; i < upperArr.Length; i++)
        //{
        //    result[i] = upperArr[i] + midPart[i];
        //}
        Console.WriteLine(string.Join(" ", sumTwoArrays));
    }
}

