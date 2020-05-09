using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day9_Valid_Perfect_Square
    {
        public bool IsPerfectSquare(int num)
        {
            if (num <= 0) return false;
            for (int i = 1; i * i <= num; i++) {
                try
                {
                    if (checked(i * i) == num) return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            return false;
        }
    }
}
