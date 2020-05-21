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
            int result = 0;
            for (int i = 0; i < matrix.Length; i++) {
                for (int j = 0; j < matrix[i].Length; j++) {
                    Console.Write($"{matrix[i][j]} ");
                    if (matrix[i][j] == 1) {
                        int l = i, k = j;
                        bool f = false;
                        while (CheckIndex(matrix, i, j, l, k) && !f) {
                            for (int tt = i; tt <= l; tt++) {
                                for (int t = j; t <= k && !f; t++) {
                                    if (matrix[tt][t] == 0) {
                                        f = true;
                                        break;
                                    }
                                }
                            }
                            if (!f) result++;
                            l++;
                            k++;
                        }
                    }
                }
                Console.WriteLine();
            }

            return result;
        }

        private bool CheckIndex(int[][] array, int i, int j, int l, int k)
        {
            return (l < array.Length && k < array[l].Length);
        }
    }
}
