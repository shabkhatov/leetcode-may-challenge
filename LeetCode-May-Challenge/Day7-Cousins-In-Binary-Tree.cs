using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
    class Day7_Cousins_In_Binary_Tree
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            var depthx = findDepth(root, 1, x, -1);
            var depthy = findDepth(root, 1, y, -1);
            if (depthx.Key == depthy.Key) {
                return depthx.Value != depthy.Value;
            }
            return false;
        }

        private KeyValuePair<int,int> findDepth(TreeNode root, int depth, int val, int parent)
        {
            if (root == null) return new KeyValuePair<int, int>(-1, -1);
            if (root.val == val) return new KeyValuePair<int, int>(depth, parent);
            var leftDepth = findDepth(root.left, depth + 1, val, root.val);
            var right = findDepth(root.right, depth + 1, val, root.val);

            if (leftDepth.Key == -1) return right;
            return leftDepth;
        }
    }
}
