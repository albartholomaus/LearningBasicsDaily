using LearningBasics.BasicsOrBasics.Hash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Trees
{
    public class IsValidBST_Class
    {

        public IsValidBST_Class()
        {
            TreeNode root = new(2);
            root.left = new(1);
            root.right = new(3);
            IsValidBST(root);
        }
        public bool IsValidBST(TreeNode root)
        {
            return IsValid(root, long.MinValue, long.MaxValue);
        }

        private bool IsValid(TreeNode root, long left, long right)
        {
            if (root == null) return true;

            if (!(left < root.val && root.val < right)) return false;

            return IsValid(root.left, left, root.val) && IsValid(root.right, root.val, right);
        }
    }
}
