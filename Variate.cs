class Program
{
    static bool[] used;
    static int[] variation;
    static int[] elements;

    static void Main()
    {
        elements = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int k = int.Parse(Console.ReadLine());
        used = new bool[elements.Length];
        variation = new int[k];

        Variate(0, k);
    }

    private static void Variate(int index, int k)
    {
        //проверяваме дали имаме решение
        if (index >= k)
        {
            //и го извеждаме или запазваме
            Console.WriteLine(string.Join(" ", variation));
            return;
        }

        //опитваме да разширим решението с всеки възможен вариант
        for (int i = 0; i < elements.Length; i++)
        {
            //ако е възможно да разширим решението
            if (!used[i])
            {
                //маркираме елемента като използван и го добавяме към решението
                used[i] = true;
                variation[index] = elements[i];
                //извикваме рекурсивно следващата стъпка от решението
                Variate(index + 1, k);
                //след връщане от рекурсията, дерегистрираме решението
                used[i] = false;
            }
        }
    }
}
