using GraphNeighbouts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphNeighbouts
{
    public class GraphMatrix
    {
        private int[,] matrix;
        public int Verticies { get; set; }
        public GraphMatrix(int verticies)
        {
            matrix = new int[verticies + 1, verticies + 1];
            Verticies = verticies;
        }

        public void AddEdge(int from, int to, bool bidirectional = true)
        {
            matrix[from, to] = 1; //should be the weight if the graph is weighted
            if (bidirectional)
            {
                matrix[to, from] = 1;
            }
        }

        public void Print()
        {
            for (int i = 1; i <= Verticies; i++)
            {
                for (int j = 1; j <= Verticies; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
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
GraphMatrix graph = new GraphMatrix(verticies);
for (int i = 0; i < edges; i++)
{
    int[] edge = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    int from = edge[0];
    int to = edge[1];
    graph.AddEdge(from, to, true); //true - unoriented (biderectional), false - oriented
}

graph.Print();
