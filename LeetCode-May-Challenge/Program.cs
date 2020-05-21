using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day21_Count_Square_Submatrices_with_All_Ones().CountSquares(
                new int[][] {
                  new int[] { 1, 0, 1 },
                  new int[] { 1, 1, 0 },
                  new int[] { 1, 1, 0 }
                }
            );
            Console.WriteLine("Result " + result);
            Console.Read();
        }
    }
}
    