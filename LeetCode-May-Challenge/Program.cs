using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day20_Kth_Smallest_in_BST().KthSmallest(
                new Day20_Kth_Smallest_in_BST.TreeNode(5, 
                    new Day20_Kth_Smallest_in_BST.TreeNode(3,
                        new Day20_Kth_Smallest_in_BST.TreeNode(2,
                            new Day20_Kth_Smallest_in_BST.TreeNode(1),
                            null
                        ),
                        new Day20_Kth_Smallest_in_BST.TreeNode(4)
                    ),
                    new Day20_Kth_Smallest_in_BST.TreeNode(6)
                ),
                3
            );
            Console.WriteLine("Result " + result);
            Console.Read();
        }
    }
}
    