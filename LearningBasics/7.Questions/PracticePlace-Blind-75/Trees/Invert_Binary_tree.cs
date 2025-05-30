using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.PracticePlace.Trees
{
    public class Invert_Binary_tree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if(root==null) return root;

            InvertTree(root.left);
            InvertTree(root.right);

            TreeNode tempStore = root.left;
            root.left = root.right;
            root.right = tempStore;

            return root;
        }
        public TreeNode InvertTreeBFS(TreeNode root)
        {
            if (root == null) return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                TreeNode temp = node.left;
                node.left = node.right;
                node.right = temp;
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            return root;
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
