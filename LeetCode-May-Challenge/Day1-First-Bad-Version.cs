using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day1_First_Bad_Version
    {
        public int FirstBadVersion(int n)
        {
            int l = 1;
            int r = n;
            while (l < r)
            {
                int mid = checked(l + (r - l) / 2);
                if (!IsBadVersion(mid))
                {
                    l = mid + 1;
                }
                else r = mid;
            }

            return l;
        }

        private bool IsBadVersion(int mid)
        {
            throw new NotImplementedException();
        }
    }
}
