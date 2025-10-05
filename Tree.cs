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

        public Tree(T value, params Tree<T>[] children)
        {
            Value = value;
            Children = new List<Tree<T>>(children);
        }

        public void Print(int spaces = 1)
        {
            Console.WriteLine($"{new string(' ', spaces)}{Value}");
            foreach (var child in Children)
            {
                child.Print(spaces * 2);
            }
        }
    }
}


Program.cs:
using TreeExample;

Tree<int> tree =
new Tree<int>(7,
new Tree<int>(19,
new Tree<int>(1),
new Tree<int>(12),
new Tree<int>(31)),
new Tree<int>(21),
new Tree<int>(14,
new Tree<int>(23),
new Tree<int>(6))
);

tree.Print();
