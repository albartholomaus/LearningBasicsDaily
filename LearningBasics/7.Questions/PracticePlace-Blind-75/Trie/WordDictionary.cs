using LearningBasics._5.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Trie
{
    public class WordDictionary
    {
        private TrieNode root;
        public WordDictionary()
        {
            root = new TrieNode();
            AddWord("dog");
            //AddWord("bay");
            //AddWord("may");
            Search("do.."); // return false
            //Search("day"); // return true
            //Search(".ay"); // return true
            //Search("b.*"); // return true
        }

        public void AddWord(string word)
        {
            TrieNode current = root;

            foreach (var chr in word)
            {
                if (current.Children[chr - 'a'] == null)
                {
                    current.Children[chr - 'a'] = new TrieNode();
                }
                current = current.Children[chr - 'a'];
            }
            current.endOfWord = true;
        }

        public bool Search(string word)
        {
            return Dfs(word, 0, root);
        }

        private bool Dfs(string word, int wordIndex, TrieNode root)
        {
            TrieNode current = root;

            for (int i = wordIndex; i < word.Length; i++)
            {
                var currentChar = word[i];
                if (word[i] == '.' || word[i] == '*')
                {
                    int count = 0;
                    foreach (TrieNode child in current.Children)
                    {
                        count++;
                        if (child != null && Dfs(word, i + 1, child))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else
                {
                    if (current.Children[word[i] - 'a'] == null) return false;
                    current = current.Children[word[i] - 'a'];
                }
                
            }
            return current.endOfWord;
        }
    }
    public class TrieNode
    {
        public TrieNode[] Children = new TrieNode[26];
        public bool endOfWord = false;
    }
}
