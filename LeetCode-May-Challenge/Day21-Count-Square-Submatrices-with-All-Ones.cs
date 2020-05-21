using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day21_Count_Square_Submatrices_with_All_Ones
    {
        public int CountSquares(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            int count = 0;
            int[,] dp = new int[n + 1, m + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (matrix[i - 1][j - 1] == 1)
                    {
                        dp[i, j] = 1 + Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1]));
                        count += dp[i, j];
                    }
                }
            }

            return count;
        }

        private bool CheckIndex(int[][] array, int i, int j, int l, int k)
        {
            return (l < array.Length && k < array[l].Length);
        }
    }
}
