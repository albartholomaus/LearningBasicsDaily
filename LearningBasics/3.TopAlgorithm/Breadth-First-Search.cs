using LearningBasics.HelperClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LearningBasics._3.TopAlgorithm
{
    public class Breadth_First_Search
    {
        public void BFS(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root != null)
            {
                queue.Enqueue(root);
            }
            int level = 0;
            while (queue.Count > 0)
            {
                Console.WriteLine($"level {level}:");
                int levelLength = queue.Count;
                for (int i = 0; i < levelLength; i++)
                {
                    TreeNode curr = queue.Dequeue();
                    Console.WriteLine(curr.value);
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                level++;
                Console.WriteLine();
            }
        }
        public void BFSP(TreeNode root)
        {
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            int level = 1;
            while (queue.Any())
            {
                for (int i = 0; i < queue.Count; i++)
                {
                    TreeNode current = queue.Dequeue();
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }
                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }
                level++;
            }
        }

    }
}
