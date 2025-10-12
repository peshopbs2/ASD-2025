using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    private static int vertices;
    private static bool[] starters;
    private static Dictionary<int, List<int>> graph;
    private static int[] inCount;
    private static bool[] used;
    private static List<int> result;
    public static void Main(string[] args)
    {
        vertices = int.Parse(Console.ReadLine());
        string data = Console.ReadLine();
        graph = new Dictionary<int, List<int>>();
        for(int i = 0; i < vertices; i++)
        {
            graph[i] = new List<int>();
        }

        inCount = new int[vertices];
        starters = new bool[vertices];
        while (data != "hopstop")
        {
            int[] edge = data.Split()
                .Select(int.Parse)
                .ToArray();
            int from = edge[0];
            int to = edge[1];
            graph[from].Add(to);
            inCount[to]++;

            data = Console.ReadLine();
        }
        used = new bool[vertices];
        result = new List<int>();
        TopSort();
    }

    private static void TopSort()
    {
        for (int i = 0; i < vertices; i++)
        {
            if (!used[i] && inCount[i] == 0)
            {
                used[i] = true;
                result.Add(i);
                foreach (int neighbour in graph[i])
                {
                    inCount[neighbour]--;
                }

                TopSort();
                used[i] = false;
                result.Remove(i);
                foreach (int neighbour in graph[i])
                {
                    inCount[neighbour]++;
                }
            }
        }

        if (result.Count == vertices && starters[result[0]] == false)
        {
            starters[result[0]] = true;
            Console.WriteLine(string.Join(" -> ", result));
        }
    }
}
