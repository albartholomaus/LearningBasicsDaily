using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.HelperClasses
{
    public class TreeNode
    {
        public TreeNode left { get; set; }
        public int value { get; set; }
        public TreeNode right { get; set; }

        public TreeNode(int value, TreeNode left = null, TreeNode right = null)
        {
            this.left = left;
            this.value = value;
            this.right = right;
        }
    }
}
