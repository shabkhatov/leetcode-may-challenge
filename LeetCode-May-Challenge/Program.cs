using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day27_Possible_Bipartition().PossibleBipartition(5,
                new int[][] {
                    new int[]{ 1,2},
                    new int[]{ 2,3},
                    new int[]{ 3,4},
                    new int[]{ 4,5},
                    new int[]{ 1,5}
                }

            );
            Console.WriteLine("Result " + result);
            Console.Read();
        }
    }
}
    