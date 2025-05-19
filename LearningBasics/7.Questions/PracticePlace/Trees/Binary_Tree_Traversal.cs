using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Trees
{
    public class Binary_Tree_Traversal
    {
        public Binary_Tree_Traversal()
        {
            TreeNode root = new(1);
            root.left = new(2);
             root.left.left = new(4);
             root.left.right = new(5);

            root.right = new(3);
            root.right.right = new(7);
            root.right.left = new(6);
            LevelOrder(root);
        }

        public List<List<int>> LevelOrder(TreeNode root)
        {
           
            Queue<TreeNode> queue = new();
            List<List<int>> returnList = new();
            if (root != null)
            {
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    List<int> addToReturnlist = new();

                    int levelLength = queue.Count;

                    for (int i = 0; i < levelLength; i++)
                    {
                        TreeNode current = queue.Dequeue();
                        addToReturnlist.Add(current.val);
                        if (current.left != null) queue.Enqueue(current.left);
                        if (current.right != null) queue.Enqueue(current.right);
                    }
                    returnList.Add(addToReturnlist);
                }
            }
            return returnList;
        }

    }
}
