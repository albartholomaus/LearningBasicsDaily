using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.BasicsOrBasics.Tree
{
    public class CreateTree
    {
        public TreeNode tree;
        public TreeNode Insert(TreeNode root, int value)
        {
            return tree;
        }
        public TreeNode Remove(TreeNode root, int value)
        {
            return root;
        }
        public class TreeNode
        {
            public TreeNode left { get; set; }
            public TreeNode right { get; set; }
            public int value { get; set; }
            public TreeNode(int value)
            {
                left = null;
                right = null;
                this.value = value;
            }
        }
    }
}

