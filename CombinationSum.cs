class Program
{
    static bool[] used;
    static int[] combination;
    static int[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    static int targetSum = 0;

    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        targetSum = int.Parse(Console.ReadLine());
        used = new bool[elements.Length];
        combination = new int[k];

        Combinate(0, 0, k);
    }

    private static void Combinate(int index, int start, int k)
    {
        if (index >= k)
        {
            if (combination.Sum() == targetSum)
            {
                Console.WriteLine(string.Join(" ", combination));
            }

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
