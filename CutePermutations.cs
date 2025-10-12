class Program
{
    private static int[] arr;
    private static bool[] used;
    private static int[] perm;
    static void Main()
    {
        arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Array.Sort(arr);

        used = new bool[arr.Length];
        perm = new int[arr.Length];
        Permute(0);
    }

    private static void Permute(int index)
    {
        if (index >= arr.Length)
        {
            int count = Count(perm);
            if (count != 0 && count % 2 == 0)
            {
                Console.WriteLine(string.Join(" ", perm));
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (!used[i])
            {
                used[i] = true;
                perm[index] = arr[i];
                Permute(index + 1);
                used[i] = false;
            }
        }
    }

    private static int Count(int[] perm)
    {
        int count = 0;
        for (int i = 0; i < perm.Length - 1; i++)
        {
            if (perm[i] > perm[i + 1])
            {
                count++;
            }
        }
        return count;
    }
}
