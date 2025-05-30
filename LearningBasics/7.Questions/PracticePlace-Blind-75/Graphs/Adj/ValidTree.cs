using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Graphs
{
    public class ValidTreeClass
    {


        public ValidTreeClass()
        {
            int n = 5;
            int[][] edges = [[0, 1], [0, 2], [0, 3], [2, 0]];
            ValidTree(n, edges);
        }
        public bool ValidTree(int n, int[][] edges)
        {
            List<List<int>> adj = new();
            for (int i = 0; i < n; i++)
            {
                adj.Add(new List<int>());
            }
            //because the graph is undirected, you must also record that edge[1] is connected back to edge[0].
            foreach (var edge in edges)
            {
                adj[edge[0]].Add(edge[1]);
                adj[edge[1]].Add(edge[0]);
            }

            HashSet<int> visited = new();

            if (!Dfs(0, -1, visited, adj))
            {
                return false;
            }
            return visited.Count == n;
        }

        private bool Dfs(int currentNode, int parentNode, HashSet<int> visited, List<List<int>> adj)
        {

            if (visited.Count > 0 && visited.Contains(currentNode)) return false;
            visited.Add(currentNode);
            foreach (var neighbor in adj[currentNode])
            {
                if (neighbor == parentNode)
                {
                    continue;
                }
                if (!Dfs(neighbor, currentNode, visited, adj))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
// Goal 
// 1. makes sure we have a tree not a binary search tree but a just a valid tree. 
//2. no loops
//3. all nodes but be connected.
