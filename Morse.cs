class Program
{
    static bool[] used;
    static string[] combination;
    static string[] elements;

    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        elements = new string[k];
        for (int i = 0; i < k; i++)
        {
            elements[i] = Console.ReadLine();
        }
        combination = new string[k];

        Combinate(0, 0, k);
    }

    private static void Combinate(int index, int start, int k)
    {
        if (index >= k)
        {
            Console.WriteLine(string.Join("", combination));
            return;
        }

        for (int i = start; i < elements.Length; i++)
        {
            combination[index] = elements[i];
            Combinate(index + 1, i, k);
        }
    }
}
