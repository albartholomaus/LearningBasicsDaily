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
using System.Diagnostics.CodeAnalysis;

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
                Insert(root, array[value]);
            }
            RemoveP(root, 10);
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
            if (root.value < value)
            {
                root.left = InsertP(root.left, value);
            }
            else if (root.value > value)
            {
                root.right = InsertP(root.right, value);
            }
            return root;
        }

        public TreeNode Remove(TreeNode root, int value)
        {
            //base case , also handles childless nodes as it retuns null to the previous call and it then makes that node null. 
            if (root == null)
            {
                return null;
            }
            //the next 2 are for finding the right path 
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
                //the next to here are, as we are removing,we found the value and we are removing the found value and returing an actual value to replace it with. because we are removing it. if on or the other is null we can remove it. in the even of removing a chidless node the case case would handle it. 
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
                    //we need to firt find the lost value node. we could do this from the left to find the higest node but as we are going right we will need to find the lowest. 
                    TreeNode minNode = MinValueNodeP(root.right);
                    //we are at a node that we need to replace, here are are taking said minNode value and add it to the root value 
                    root.value = minNode.value;
                    //Now we need to remove the node that we replace the value with. it is much easier to do this then to remove said now and replace it. 
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
            if (root.value < value)
            {
                root.left = InsertP(root.left, value);
            }
            else if (root.value > value)
            {
                root.right = InsertP(root.right, value);
            }
            else
            {
                if (root.left == null)
                {
                    return root.right;
                }
                if (root.right == null)
                {
                    return root.left;
                }
                else
                {
                    TreeNode minNode = MinValueNodeP(root.right);
                    root.value = minNode.value;
                    root.right = RemoveP(root.right,minNode.value);
                }
            }
            return root;
        }

        private TreeNode MinValueNodeP(TreeNode root)
        {
            while (root.left != null && root != null)
            {
                root = root.left;
            }
            return root;
        }

        private TreeNode MinValueNode(TreeNode root)
        {
            while (root.left != null && root != null)
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
                return SearchTree(root.right, target);
            }
            if (target < root.value)
            {
                return SearchTree(root.left, target);
            }
            else
            {
                return true;
            }
        }
        public bool SearchTreeP(TreeNode root, int value )
        {
            if (root.value == value)
            {
                return true;
            }
            if (root.value < value)
            {
                SearchTreeP(root.left, value);
            }
            else if (root.value > value)
            {
                SearchTreeP(root.right, value);
            }
            return false;
        }


    }
}

