using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day29_Course_Schedule().CanFinish(2, new int[][] {
                new int[]{ 1, 0}
            });
            Console.WriteLine("Result " + result);
            Console.Read();
        }
    }
}
    