using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day30_K_Closest_Points_To_Origin().KClosest(
                new int[][] {
                    new int[]{ 3,3},
                    new int[]{ 5,-1},
                    new int[]{ -2, 4}
                },
                2
            );
            Console.WriteLine("Result " + result);
            Console.Read();
        }
    }
}
    