using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day27_Possible_Bipartition
    {
        public bool PossibleBipartition(int N, int[][] dislikes)
        {
            var adj = dislikes
                .Aggregate(
                    new Dictionary<int, HashSet<int>>(),
                    (acc, x) => {
                        if (!acc.ContainsKey(x[0]))
                        {
                            acc[x[0]] = new HashSet<int>();
                        }

                        if (!acc.ContainsKey(x[1]))
                        {
                            acc[x[1]] = new HashSet<int>();
                        }

                        acc[x[0]].Add(x[1]);
                        acc[x[1]].Add(x[0]);
                        return acc;
                    }
                );

            var visited = Enumerable.Repeat(0, N + 1).ToArray();

            for (var i = 1; i <= N; i++) {
                if (visited[i] == 0) {
                    if (!DFS(i, adj, visited, 1)) {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool DFS(int i, Dictionary<int, HashSet<int>> adj, int[] visited, int team)
        {
            visited[i] = team;
            if (!adj.ContainsKey(i))
            {
                return true;
            }

            foreach (var v in adj[i])
            {
                if (visited[v] == 3 - team)
                {
                    continue;
                }

                if (visited[v] == team)
                {
                    return false;
                }

                adj[v].Remove(i);
                if (!DFS(v, adj, visited, 3 - team))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
