using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day23_Interval_List_Intersections().IntervalIntersection(
                new int[][] {
                    new int[] {1, 8 },
                    new int[] {16, 20 },
                },
                new int[][] {
                    new int[]{2, 11 },
                    new int[]{12, 13 }
                }
            );
            Console.WriteLine("Result " + result);
            for (int i = 0; i < result.Length; i++) {
                Console.WriteLine($"{result[i][0]} {result[i][1]}");
            }
            Console.Read();
        }
    }
}
    