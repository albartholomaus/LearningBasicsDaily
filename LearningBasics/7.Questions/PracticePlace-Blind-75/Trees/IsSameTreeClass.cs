using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Trees
{
    public class IsSameTreeClass
    {
        public IsSameTreeClass()
        {
            TreeNode rootp = new(1);
            rootp.left = new(2);
            rootp.right = new(3);

            TreeNode rootq = new(1);
            rootq.left = new(2);
            rootq.right = new(3);

            IsSameTree(rootp, rootq);

        }
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;

            if (p == null || q == null || p.val != q.val) return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
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
