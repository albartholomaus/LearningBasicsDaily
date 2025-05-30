using LearningBasics._5.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.Graphs
{
    public class CloneGraphClass
    {
        public Node CloneGraph(Node node)
        {
            Dictionary<Node, Node> ClonedCopies = new();
            return Dfs(node,ClonedCopies);
        }

        private Node Dfs(Node node, Dictionary<Node, Node> clonedCopies)
        {
            if (node == null) return null;

            if (clonedCopies.ContainsKey(node)) return clonedCopies[node];

            Node copy = new Node(node.val);
            clonedCopies[node]= copy;
                

            foreach (var neighbor in node.neighbors)
            {
                copy.neighbors.Add(Dfs(neighbor,clonedCopies));
            }
            return copy;
        }
    }
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
