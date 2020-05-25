using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day25_Uncrossed_lines().MaxUncrossedLines(
                new int[] { 1, 4, 2 },
                new int[] { 1, 2, 4 }
            );
            Console.WriteLine("Result " + result);
            Console.Read();
        }
    }
}
    