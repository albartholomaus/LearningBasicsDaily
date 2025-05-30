using LearningBasics._5.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics._7.Questions.PracticePlace.Graphs
{
    public class CountComponentsClass
    {
        public int CountComponents(int n, int[][] edges)
        {
            List<List<int>> adj = new();
            HashSet<int> visited = new();
            for (int i = 0; i < n; i++)
            {
                adj.Add(new List<int> { });
            }
            foreach (var edge in edges)
            {
                adj[edge[0]] = adj[edge[1]];
                adj[edge[1]] = adj[edge[0]];
            }
            int result = 0;

            //So that for‑loop is the standard pattern for counting connected components: you “seed” a DFS on every unvisited node, ensuring you cover—and count—every disconnected piece of the graph.
            for (int node = 0; node < n; node++)
            {
                if (!visited.Contains(node))
                {
                    Dfs(adj,visited,node);
                }
            }
            return result;
        }

        private void Dfs(List<List<int>> adj, HashSet<int> visited, int node)
        {
            if (visited.Contains(node)) return;
            foreach (var neighbor in adj[node])
            {
                if (!visited.Contains(neighbor))
                {
                    Dfs( adj, visited, neighbor);
                }
            }
        }
    }
}
