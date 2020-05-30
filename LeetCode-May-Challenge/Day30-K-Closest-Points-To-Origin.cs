using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day30_K_Closest_Points_To_Origin
    {
        public int[][] KClosest(int[][] points, int K)
        {
            Dictionary<int, List<int[]>> map = new Dictionary<int, List<int[]>>();
            for (int i = 0; i < points.Length; i++) {
                var a = points[i][0];
                var b = points[i][1];
                var distance = a * a + b * b;
                if (map.ContainsKey(distance)) map[distance].Add(new int[] { a, b });
                else map.Add(distance, new List<int[]>() { new int[] { a, b } });
            }
            var result = new int[K][];
            int temp = K;
            foreach (var kvp in map.OrderBy(x => x.Key)) {
                if (temp <= 0) break;
                foreach (var val in kvp.Value) {
                    if (temp <= 0) break;
                    result[K - temp] = new int[] { val[0], val[1] };
                    temp--;
                }
            }


            return result;

        }
    }
}
