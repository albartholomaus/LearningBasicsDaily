using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Trees
{
    public class KthSmallestClass
    {
        public int KthSmallest(TreeNode root, int k)
        {
            List<int> InOrder = new();
            InOrderHelper(root, InOrder);
            return InOrder[k - 1];
        }

        public void InOrderHelper(TreeNode root, List<int> inOrder)
        {
            if (root == null) return;

            InOrderHelper(root.left, inOrder);
            inOrder.Add(root.val);
            InOrderHelper(root.right, inOrder);
        }

    }
}
