using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Trees
{
    public class LowestCommonAncestorClass
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode current = root;
            while (current !=null)
            {
                if (p.val > current.val && q.val > current.val) current = current.right;
                else if (p.val < current.val && q.val < current.val) current = current.left;
                else return current;
            }
            return null;
        }
    }
}
