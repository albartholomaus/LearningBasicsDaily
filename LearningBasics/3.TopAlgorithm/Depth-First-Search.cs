using LearningBasics.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static LearningBasics.BasicsOrBasics.Tree.CreateTree;

namespace LearningBasics._3.TopAlgorithm
{
    public class Depth_First_Search
    {
        public void InOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.left);
            Console.WriteLine(root);
            InOrder(root.right);
        }
        public void PreOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root);
            InOrder(root.left);
            InOrder(root.right);
        }

        public void PostOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.left);
            InOrder(root.right);
            Console.WriteLine(root);
        }

        public void InOrderP(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.left);
            Console.WriteLine(root);
            InOrder(root.right);
        }
        public void PreOrderP(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root);
            PreOrderP(root.left);
            PreOrderP(root.right);
        }
        public void PostOrderP(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            PostOrderP(root.left);
            PostOrderP(root.right);
            Console.WriteLine(root);
        }
    }

}
