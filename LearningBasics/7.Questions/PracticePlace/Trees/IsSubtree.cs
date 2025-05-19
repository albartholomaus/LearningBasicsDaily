using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Trees
{
    public class IsSubtreeClass
    {
        public IsSubtreeClass()
        {
            TreeNode subroot = new(1);
            TreeNode root = new(1);
            root.right = new(1);

            IsSubtree(root, subroot);
        }
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null || subRoot == null) return false;

            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                for (int i = 0; i < queue.Count; i++)
                {
                    TreeNode currentRoot = queue.Dequeue();
                   
                    if (currentRoot.val==subRoot.val) return SameTree(currentRoot, subRoot);

                    if (currentRoot.left != null) queue.Enqueue(currentRoot.left);
                    if (currentRoot.right != null) queue.Enqueue(currentRoot.right);
                }
            }
            return false;
        }
        public bool SameTree(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;

            if (root1 == null || root2 == null || root1.val != root2.val) return false;

            return SameTree(root1.left, root2.left) && SameTree(root1.right, root2.right);
        }
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
