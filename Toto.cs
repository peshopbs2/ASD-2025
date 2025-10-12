class Program
{
    static int[] variation;
    static int[] elements;

    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        elements = Enumerable.Range(1, n).ToArray();

        variation = new int[k];

        Variate(0, k);
    }

    private static void Variate(int index, int k)
    {
        if (index >= k)
        {
            Console.WriteLine(string.Join(".", variation));
            return;
        }

        for (int i = 0; i < elements.Length; i++)
        {
            variation[index] = elements[i];
            Variate(index + 1, k);
        }
    }
}
