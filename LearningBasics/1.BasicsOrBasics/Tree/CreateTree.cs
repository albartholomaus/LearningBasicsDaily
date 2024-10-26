using LearningBasics.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using LearningBasics._3.TopAlgorithm;
using System.ComponentModel.Design.Serialization;
using System.Xml.Schema;
using System.Text.Json.Serialization;
using LearningBasics.BasicsOrBasics.Hash;

namespace LearningBasics.BasicsOrBasics.Tree
{
    public class CreateTree
    {

        public CreateTree()
        {

            int value = 0;
            int[] array = [50, 40, 60, 30, 70, 20, 80, 10];
            TreeNode root = new(array[value]);

            for (int i = 0; i < array.Length - 1; i++)
            {
                value++;
                InsertP(root, array[value]);
            }
            RemoveP(root, 10);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public TreeNode Insert(TreeNode root, int value)
        {
            if (root == null)
            {
                return new TreeNode(value);
            }
            if (value > root.value)
            {
                root.right = Insert(root.right, value);
            }
            else if (value < root.value)
            {
                root.left = Insert(root.left, value);
            }
            return root;
        }
        public TreeNode InsertP(TreeNode root, int value)
        {
            if (root == null)
            {
                return new TreeNode(value);
            }
            if (value<root.value)
            {
                root = InsertP(root.left, value);
            }
            if (value > root.value)
            {
                root = InsertP(root.right, value);
            }
            return root;
        }

        public TreeNode Remove(TreeNode root, int value)
        {
            if (root == null)
            {
                return null;
            }
            if (value > root.value)
            {
                root.right = Remove(root.right, value);
            }
            else if (value < root.value)
            {
                root.left = Remove(root.left, value);
            }
            else
            {
                if (root.left == null)
                {
                    return root.right;
                }
                else if (root.right == null)
                {
                    return root.left;
                }
                else
                {
                    TreeNode minNode = MinValueNode(root.right);
                    root.value = minNode.value;
                    root.right = Remove(root.right, minNode.value);
                }
            }
            return root;
        }

        public TreeNode RemoveP(TreeNode root, int value)
        {
            if (root == null)
            {
                return null;
            }
            if (value < root.value)
            {
                root = RemoveP(root.left, value);
            }
            if (value > root.value)
            {
                root = RemoveP(root.right, value);
            }
            else
            {
                if (root.left==null)
                {
                    return root.right;
                }
                else if (root.right == null)
                {
                    return root.left;
                }
                else
                {
                    
                }
            }

        }


        private TreeNode MinValueNode(TreeNode root)
        {
            while (root != null && root.left != null)
            {
                root = root.left;
            }
            return root;
        }


        public bool SearchTree(TreeNode root, int target)
        {
            if (root == null)
            {
                return false;
            }
            if (target > root.value)
            {
                return SearchTree(root.left, target);
            }
            if (target < root.value)
            {
                return SearchTree(root.right, target);
            }
            else
            {
                return true;
            }
        }



    }
}

