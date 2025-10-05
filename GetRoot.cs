using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExample
{
    public class Tree<T>
    {
        public T Value { get; set; }
        public List<Tree<T>> Children { get; set; }
        public Tree<T> Parent { get; set; }

        public Tree(T value, params Tree<T>[] children)
        {
            Value = value;
            Children = new List<Tree<T>>(children);
            foreach (var child in Children)
            {
                child.Parent = this;
            }
        }

        public void AddChild(Tree<T> child)
        {
            Children.Add(child);
            child.Parent = this;
        }

        public void Print(int spaces = 1)
        {
            Console.WriteLine($"{new string(' ', spaces)}{Value}");
            foreach (var child in Children)
            {
                child.Print(spaces * 2);
            }
        }

        public Tree<T> GetRoot()
        {
            Tree<T> current = this;
            while (current.Parent != null)
            {
                current = current.Parent;
            }
            return current;
        }
    }
}


Program.cs:
using TreeExample;

int n = int.Parse(Console.ReadLine());
Dictionary<int, Tree<int>> nodes = new();

for (int i = 0; i < n - 1; i++)
{
    int[] edge = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    int parent = edge[0];
    int child = edge[1];
    if (!nodes.ContainsKey(parent))
    {
        nodes[parent] = new Tree<int>(parent);
    }

    if(!nodes.ContainsKey(child))
    {
        nodes[child] = new Tree<int>(child);
    }

    nodes[parent].AddChild(nodes[child]);
}

int node = int.Parse(Console.ReadLine());
if (nodes.ContainsKey(node))
{
    Console.WriteLine(nodes[node].GetRoot().Value);
}
