using LearningBasics._5.Graphs;
using LearningBasics.Patterns.Behavioral.Strategy.Context;
using LearningBasics.PracticePlace.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Trees
{
    public class BuildTreeClass
    {
        public BuildTreeClass()
        {
            int[] preOrder = [3, 9, 20, 15, 7], inOrder = [9, 3, 15, 20, 7];
            var buildTree = BuildTree(preOrder, inOrder);
        }

        int preIndex = 0, inIndex = 0;

        public TreeNode BuildTree(int[] preorder, int[] inorder) => Dfs(preorder, inorder, int.MaxValue);

        private TreeNode Dfs(int[] preorder, int[] inorder, int limit)
        {
            
            if (preIndex >= preorder.Length) return null;

   
            if (inorder[inIndex] == limit)
            {

                inIndex++;
                return null;
            }

            int rootVal = preorder[preIndex++];
            var root = new TreeNode(rootVal);
           
            root.left = Dfs(preorder, inorder, rootVal);
        
            root.right = Dfs(preorder, inorder, limit);

            return root;
        }


        private TreeNode Dfs2(int[] preorder, int[] inorder, int limit)
        {
            // if we have consumed every element in preorder, there’s nothing left to build, so return null
            if (preIndex >= preorder.Length) return null;

            //check to see if we finished building the subtree
            if (inorder[inIndex] == limit)
            {
                //We advance inIndex to “pop” the sentinel off the inorder sequence.
                inIndex++;
                //Return null to signal “no node here” and back up one level in the recursion.
                return null;
            }

            int rootVal = preorder[preIndex++];
            var root = new TreeNode(rootVal);
            /*
             Take the next preorder value (preorder[preIndex]) as the root of the current subtree.
             Increment preIndex so that subsequent calls will use the next preorder entry.
             */

            //We pass the current node’s rootVal as the new limit: in the inorder array, everything up to (but not including) this value belongs to the left subtree.
            root.left = Dfs2(preorder, inorder, rootVal);
            //We reuse the limit that was passed into our current call. That ensures the right subtree only consumes inorder values up until our parent’s limit.
            root.right = Dfs2(preorder, inorder, limit);

            return root;
        }
    }
}
/*
 
Putting it all together
Preorder always gives you the root first → we consume one element per call to pick the current root.

Inorder lets you know when you’ve finished a subtree (by hitting the limit value).

By passing the root’s value as the new limit into the left-subtree call, you ensure that inorder values “to the left” of that root in the original traversal become its left subtree.

After the left subtree returns, the next element in inorder must be the root itself (which we “pop” by matching the limit), and then we build the right subtree up to the parent’s limit.
 
 */