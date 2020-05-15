using System;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day15_Max_Sum_Circular_Subarray().MaxSubarraySumCircular(new int[] {
                -9, 14, 24, -14, 12, 18, -18, -10, -10, -23, -2, -23, 11, 12, 18, -9, 9,
                    -29,
                12, 4, -8, 15, 11, -12, -16, -9, 19, -12, 22, 16            
            });
            Console.WriteLine("Result " + result);
            Console.Read();
        }
    }
}
    