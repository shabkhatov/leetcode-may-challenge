using System;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day8_Check_Straight_Line().CheckStraightLine(new int[][] {
                 new int []{1, 2},
                 new int []{2, 3},
                 new int []{3, 4},
                 new int []{4, 5}
            });
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
