using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolving.NonLinearDS
{
    /// <summary>
    /// Tree data structure is similar to a tree we see in nature but it is upside down. It also has a root and leaves. The root is the first node of the tree and the leaves are the ones at the bottom-most level. The special characteristic of a tree is that there is only one path to go from any of its nodes to any other node.
    /// </summary>
    public class Tree : IExecutableCode
    {
        void IExecutableCode.MainBruteForceWay()
        {
           
        }

        void IExecutableCode.MainByPattern()
        {
            // Number of nodes
            int n = 7, root = 1;
            // Adjacency list to store the tree
            var adj = new List<List<int>>();
            for (int i = 0; i <= n; i++)
                adj.Add(new List<int>());
            AddEdge(root,2,adj);
            AddEdge(root,3,adj);
            AddEdge(2,4,adj);
            AddEdge(2,5,adj);
            AddEdge(3, 6, adj);
            AddEdge(3, 7, adj);
            PrintChildren(1,adj);
        }
        static void PrintChildren(int root, List<List<int>> adj)
        {
            // Queue for the BFS
            var q = new Queue<int>();
            // pushing the root
            q.Enqueue(root);
            // visit array to keep track of nodes that have been
            // visited
            var vis = new int[adj.Count];
            // BFS
            while (q.Any())
            {
                int node = q.Dequeue();
                vis[node] = 1;
                Console.Write(node + "-> ");
                foreach (var cur in adj[node])
                    if (vis[cur] == 0)
                    {
                        Console.Write(cur + " ");
                        q.Enqueue(cur);
                    }
                Console.WriteLine();
            }
        }
        static void AddEdge(int x, int y, List<List<int>> adj)
        {
            adj[x].Add(y);
            adj[y].Add(x);
        }

        string IExecutableCode.Pattern()
        {
           return ("Tree");
        }

        string IExecutableCode.Problem()
        {
            return "Draw the tree";
        }
    }
}
