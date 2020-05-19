using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day19_Online_Stock_Span
    {
        public class StockSpanner
        {
            private List<int> prices;
            private List<int> dp;

            public StockSpanner()
            {
                prices = new List<int>();

                dp = new List<int>();
            }

            public int Next(int price)
            {
                int count = 1;

                for (int i = prices.Count - 1; i >= 0;) {
                    if (price < prices[i]) break;
                    
                    count += dp[i];
                    i -= dp[i];
                }

                prices.Add(price);
                dp.Add(count);

                return dp.Last();
            }
        }
    }
}
