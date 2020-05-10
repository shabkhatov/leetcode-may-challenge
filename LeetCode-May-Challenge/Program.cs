using System;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day10_Find_the_Town_Jugde().FindJudge(4, new int[][] {
                new int[]{ 1,3},
                new int[]{ 1,4},
                new int[]{ 2,3},
                new int[]{ 2,4},
                new int[]{ 4,3}
            }); 
            Console.WriteLine("Result " + result);
            Console.Read();
        }
    }
}
