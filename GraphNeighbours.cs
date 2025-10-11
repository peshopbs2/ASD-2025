using GraphNeighbouts;

namespace GraphNeighbouts
{
    public class Graph
    {
        Dictionary<string, List<string>> graph = new();

        public void AddEdge(string from, string to, bool bidirectional = true)
        {
            if (!graph.ContainsKey(from))
            {
                graph[from] = new List<string>();
            }
            graph[from].Add(to);

            if (bidirectional)
            {
                if (!graph.ContainsKey(to))
                {
                    graph[to] = new List<string>();
                }
                graph[to].Add(from);
            }
        }

        public void Print()
        {
            foreach (var item in graph)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value)}");
            }
        }
    }
}


int[] data = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int verticies = data[0];
int edges = data[1];
Graph graph = new Graph();
for (int i = 0; i < edges; i++)
{
    string[] edge = Console.ReadLine().Split();
    string from = edge[0];
    string to = edge[1];
    graph.AddEdge(from, to, true); //true - unoriented (biderectional), false - oriented
}

graph.Print();
