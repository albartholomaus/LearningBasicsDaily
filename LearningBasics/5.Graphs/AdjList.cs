using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net.Quic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LearningBasics._5.Graphs
{
    public class AdjList
    {
        HashSet<string> visited = new();
        public AdjList()
        {

            // Console.WriteLine(length);

        }
        public Dictionary<string, List<string>> BuildAdjlist()
        {
            Dictionary<string, List<string>> adjList = new();

            string[][] edges = { ["A", "B"], ["B", "C"] };
            // HashSet<string> visit = new();
            adjList.Add("A", new List<string>());

            foreach (var edge in edges)
            {
                string src = edge[0], dst = edge[1];
                if (!adjList.ContainsKey(src))
                {
                    adjList.Add(src, new List<string>());
                }
                if (!adjList.ContainsKey(dst))
                {
                    adjList.Add(dst, new List<string>());
                }
                adjList[src].Add(dst);
            }
            return adjList;
        }
        public Dictionary<string, List<string>> BuildAdjP()
        {
            Dictionary<string, List<string>> adjList = new();
            string[][] edges = { ["A", "B"], ["C", "D"], ["B", "D"] };

            foreach (var edge in edges)
            {
                string src = edge[0], dest = edge[1];
                if (!adjList.ContainsKey(src))
                {
                    adjList.Add(src, new List<string>());
                }
                if (!adjList.ContainsKey(dest))
                {
                    adjList.Add(dest, new List<string>());
                }
                adjList[src].Add(dest);
            }
            return adjList;
        }


        public int Dfs(string node, string target, Dictionary<string, List<string>> adjlist, HashSet<string> visit)
        {
            if (visit.Contains(node))
            {
                return 0;
            }
            if (node == target)
            {
                return 1;
            }
            int count = 0;
            // visit = new HashSet<string> { node };///this is wrong as it reset the visited hashSet. 
            visit.Add(node);
            foreach (string neighbor in adjlist[node])
            {
                count += Dfs(neighbor, target, adjlist, visit);
            }
            visit.Remove(node);
            return count;
        }
        public int DFS(string node, String target, Dictionary<string, List<string>> adjlist, HashSet<string> visited)
        {
            if (visited.Contains(node))
            {
                return 0;
            }
            if (node == target)
            {
                return 1;
            }
            visited.Add(node);
            int count = 0;
            foreach (var neighbor in adjlist[node])
            {
                count += DFS(neighbor, target, adjlist, visited);
            }
            visited.Remove(node);
            return count;

        }

        public int BFS(string node, string target, Dictionary<string, List<string>> adjlist)
        {
            int length = 0;
            HashSet<string> visit = new HashSet<string>();
            Queue<string> queue = new();
            visit.Add(node);
            queue.Enqueue(node);

            while (queue.Count != 0)
            {
                int queueLength = queue.Count;
                for (int i = 0; i < queueLength; i++)
                {
                   // string current = queue.Peek();//this is extra for no reason 
                    string current= queue.Dequeue();// need to remove from the queue and add it to the foreach to add in the next "level":
                   
                    if (current.Equals(target))// need to end the BFS once we found the length 
                    {
                        return length;
                    }
                    //move through the "Level" of each neighbor to see if is added to the visited. if it has not then we makwe it so. 
                    foreach (var neighbor in adjlist[current])
                    {
                        if (!visit.Contains(neighbor))
                        {
                            visit.Add(neighbor);
                            queue.Enqueue(neighbor);
                        }
                    }
                }
                length++;
            }
            return length;
        }
        public int BFSP(string node, string target, Dictionary<string, List<string>> adjList)
        {
            Queue<string> queue = new();
            HashSet<string> visisted = new();
            queue.Enqueue(node);
            visited.Add(node);
            int length = 1;

            while (queue.Any())
            {
                for (int i = 0; i < queue.Count; i++)
                {
                    string current = queue.Dequeue();
                    if (current == target)
                    {
                        return length;
                    }

                    foreach (var neighbor in adjList[current])
                    {

                        if (!adjList.ContainsKey(neighbor))
                        {
                            queue.Enqueue(neighbor);
                            visisted.Add(neighbor);
                        }
                    }
                }
                length++;
            }
            return length;
        }


    }
}
