class Program
{
    static bool[] used;
    static int[] perm;
    static int[] elements;

    static void Main()
    {
        elements = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        used = new bool[elements.Length];
        perm = new int[elements.Length];

        Permute(0);
    }

    private static void Permute(int index)
    {
        if(index >= elements.Length)
        {
            Console.WriteLine(string.Join(" ", perm));
            return;
        }

        for(int i = 0; i < elements.Length; i++)
        {
            if (!used[i])
            {
                used[i] = true;
                perm[index] = elements[i];
                Permute(index + 1);
                used[i] = false;
            }
        }
    }
}
