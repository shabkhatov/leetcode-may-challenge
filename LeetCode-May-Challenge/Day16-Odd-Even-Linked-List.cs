using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LeetCode_May_Challenge
{
    class Day16_Odd_Even_Linked_List
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        };

        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;
            ListNode first = head;
            ListNode second = head.next;
            var i = first;
            var j = second;

            while (j != null && j.next != null)
            {
                i.next = j.next;
                i = i.next;
                j.next = i == null ? null : i.next;
                j = j.next;
            }

            i.next = second;
            return first;
        }
    }
}
