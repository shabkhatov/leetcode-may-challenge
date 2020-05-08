using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day8_Check_Straight_Line
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length == 2) return true;
            var x1 = coordinates[0][0];
            var y1 = coordinates[0][1];
            var x2 = coordinates[1][0];
            var y2 = coordinates[1][1];
            if (x1 == x2)
            {
                foreach (var coordinate in coordinates)
                {
                    if (coordinate[0] != x1) return false;
                }
            }
            else {
                double eps = 0.0001;
                double k = (double)(y2 - y1) / (x2 - x1);
                foreach (var coordinate in coordinates) {
                    if (Math.Abs(coordinate[1] - (k * (coordinate[0] - x1) + y1)) > eps) {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
