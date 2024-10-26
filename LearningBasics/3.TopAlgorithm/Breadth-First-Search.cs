using LearningBasics.HelperClasses;
using System;
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
            int testTarget = 100;
            Queue<TreeNode> queue = new();
            int level = 0;
            if (root!=null)
            {
                queue.Enqueue(root);
            }
            while (queue.Any())
            {
                Console.WriteLine(level);
                for (int i = 0; i < queue.Count; i++)
                {

                    if (root.left !=null)
                    {
                        queue.Enqueue(root.left);
                    }
                    if (root.right != null)
                    {
                        queue.Enqueue(root.right);
                    }
                }
                level++;
            }        
        } 

    }
}
