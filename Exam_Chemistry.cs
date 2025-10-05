class Program
{
    static bool[] used;
    static string[] combination;
    static string[] elements;
    static string[] priority;
    static int k;
    static void Main()
    {
        elements = Console.ReadLine().Split();
        used = new bool[elements.Length];
        k = int.Parse(Console.ReadLine());
        combination = new string[k];
        priority = Console.ReadLine().Split();

        Combination(0, 0);
    }

    private static void Combination(int index, int start)
    {
        if (index >= k)
        {
            string[] result = combination.OrderBy(item =>
             Array.IndexOf(priority, item) != -1 ?
             Array.IndexOf(priority, item) : 9999)
                .ToArray();
            Console.WriteLine(string.Join(" ", result));
            return;
        }

        for (int i = start; i < elements.Length; i++)
        {
            if (!used[i])
            {
                used[i] = true;
                combination[index] = elements[i];
                Combination(index + 1, i + 1);
                used[i] = false;
            }
        }
    }
}
