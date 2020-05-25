using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day25_Uncrossed_lines
    {
        public int MaxUncrossedLines(int[] A, int[] B)
        {
            int[][] dp = new int[A.Length + 1][];
            for (int i = 0; i < dp.Length; i++) {
                dp[i] = new int[B.Length + 1];
            }
            for (int i = 1; i < dp.Length; i++) {
                for (int j = 1; j < dp[i].Length; j++) {
                    if (A[i - 1] == B[j - 1])
                    {
                        dp[i][j] = dp[i - 1][j - 1] + 1;
                    }
                    else
                    {
                        dp[i][j] = Math.Max(dp[i - 1][j], dp[i][j - 1]);
                    }
                }
            }
            return dp[A.Length][B.Length];
        }
    }
}
