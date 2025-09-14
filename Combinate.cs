class Program
{
    static bool[] used;
    static int[] combination;
    static int[] elements;

    static void Main()
    {
        elements = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int k = int.Parse(Console.ReadLine());
        used = new bool[elements.Length];
        combination = new int[k];

        Combinate(index: 0, start: 0, k);
    }

    private static void Combinate(int index, int start, int k)
    {
        if (index >= k)
        {
            Console.WriteLine(string.Join(" ", combination));
            return;
        }

        for (int i = start; i < elements.Length; i++)
        {
            if (!used[i])
            {
                used[i] = true;
                combination[index] = elements[i];
                Combinate(index + 1, i + 1, k);
                used[i] = false;
            }
        }
    }
}
