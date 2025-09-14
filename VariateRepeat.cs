class Program
{
    static string[] variation;
    static string[] elements;

    static void Main()
    {
        elements = Console.ReadLine()
            .Split();
        int k = int.Parse(Console.ReadLine());
        variation = new string[k];

        Variate(0, k);
    }

    private static void Variate(int index, int k)
    {
        if (index >= k)
        {
            Console.WriteLine(string.Join(" ", variation));
            return;
        }

        for (int i = 0; i < elements.Length; i++)
        {
            variation[index] = elements[i];
            Variate(index + 1, k);
        }
    }
}
