using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Trees
{
    public class MaxDepthClass
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            int level = 0;
            while (queue.Count > 0)
            {
                int queueLength = queue.Count;
                for (int i = 0; i < queueLength; i++)
                {
                    TreeNode current = queue.Dequeue();
                    if (current.left != null) queue.Enqueue(current.left);
                    if (current.right != null) queue.Enqueue(current.right);
                }
                level++;
            }
            return level;
        }
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

    }
}
