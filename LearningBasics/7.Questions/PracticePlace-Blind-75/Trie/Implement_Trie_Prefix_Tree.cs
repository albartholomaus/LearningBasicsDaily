using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Trie
{
    public class PrefixTree
    {
        private TriNode root;

        public PrefixTree()
        {
            root = new TriNode();
        }

        public void Insert(string word)
        {
            TriNode current = root;
            foreach (var chr in word)
            {
                if (!current.Children.ContainsKey(chr))
                {
                    current.Children[chr] = new TriNode();
                }
                current = current.Children[chr];
            }
            current.endOfWord = true;
        }

        public bool Search(string word)
        {
            TriNode current = root;
            foreach (var chr in word)
            {
                if (!current.Children.ContainsKey(chr))
                {
                    return false;
                }
                current = current.Children[chr];
            }
            return current.endOfWord;
        }

        public bool StartsWith(string prefix)
        {
            TriNode current = root;
            foreach (var chr in prefix)
            {
                if (!current.Children.ContainsKey(chr))
                {
                    return false;
                }
                current = current.Children[chr];
            }
            return true;
        }
        private class TriNode
        {
            public Dictionary<char, TriNode> Children = new();

            public bool endOfWord = false;
        }

    }

}

