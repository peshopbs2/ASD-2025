public class Graph
{
    private List<Edge> edges = new();

    public void AddEdge(string from, string to, int weight, bool bidirectional = true)
    {
        edges.Add(new Edge(from, to, weight));
        
        if (bidirectional)
        {
            edges.Add(new Edge(to, from, weight));
        }
    }

    public void Print()
    {
        foreach (var edge in edges)
        {
            Console.WriteLine($"{edge.From} {edge.To} {edge.Weight}");
        }
    }
}

public class Edge
{
    public string From { get; set; }
    public string To { get; set; }
    public int Weight { get; set; }

    public Edge(string from, string to, int weight = 1)
    {
        From = from;
        To = to;
        Weight = weight;
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
    int weight = int.Parse(edge[2]);
    graph.AddEdge(from, to, weight, true); //true - unoriented (biderectional), false - oriented
}

graph.Print();
