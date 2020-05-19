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
            private Stack<int> prices;
            private Stack<int> counts;
            public StockSpanner()
            {
                prices = new Stack<int>();
                counts = new Stack<int>();
            }

            public int Next(int price)
            {
                int count = 1;

                while (prices.Count > 0 && prices.Peek() <= price) {
                    prices.Pop();
                    count += counts.Pop();
                }

                prices.Push(price);
                counts.Push(count);

                return counts.Peek();
            }
        }
    }
}
