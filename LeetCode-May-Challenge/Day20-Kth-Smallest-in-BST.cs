using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day20_Kth_Smallest_in_BST
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public int KthSmallest(TreeNode root, int k)
        {
            int[] nums = new int[2] { 1, 0 };
            DFS(root, nums, k);

            return nums[1];
        }

        private void DFS(TreeNode root, int[] nums, int k)
        {
            if (root.left != null)
            {
                DFS(root.left, nums, k);
                nums[0]++;
            }

            if (nums[0] == k)
            {
                nums[1] = root.val;
                return;
            }

            if (root.right != null)
            {
                nums[0]++;
                DFS(root.right, nums, k);
            }

        }
    }
}
