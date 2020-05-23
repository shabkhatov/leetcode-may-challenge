using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day23_Interval_List_Intersections
    {
        
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            if (A.Length == 0 || B.Length == 0) return new int[0][];
            int i = 0, j = 0;
            List<int[]> result = new List<int[]>();

            for (; i < A.Length && j < B.Length;) {
                int leftA = A[i][0], rightA = A[i][1], leftB = B[j][0], rightB = B[j][1];
                if (leftB > leftA)
                {
                    if (rightA < leftB)
                    {
                        i++;
                    }
                    else
                    {
                        if (rightA <= rightB)
                        {
                            result.Add(new int[2] { leftB, rightA });
                            i++;
                        }
                        else
                        {
                            result.Add(new int[2] { leftB, rightB });
                            j++;
                        }
                    }
                }
                else {
                    if (rightB < leftA)
                    {
                        j++;
                    }
                    else {
                        if (rightA > rightB)
                        {
                            result.Add(new int[2] { leftA, rightB });
                            j++;
                        }
                        else {
                            result.Add(new int[2] { leftA, rightA });
                            i++;
                        }
                    }
                }
            }

            return result.Count > 0 ? result.ToArray() : null;
        }
    }
}
