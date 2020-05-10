using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day10_Find_the_Town_Jugde
    {
        public int FindJudge(int N, int[][] trust)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            foreach (var t in trust) {
                if (dict.ContainsKey(t[1])) dict[t[1]].Add(t[0]);
                else dict.Add(t[1], new List<int>() { t[0] });
            }
            if (N == 1 && dict.Count == 0) return 1;

         
            int result = -1;
            foreach (var d in dict)
            {
                if (d.Value.Count == N - 1) {
                    if (result != -1) return -1;
                    foreach (var dd in dict) {
                        if (dd.Value.Contains(d.Key)) return -1;
                    }
                    result = d.Key;
                }
            }

            return result;
        }
    }
}
