int S = int.Parse(Console.ReadLine());

int[] nominals = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Array.Sort(nominals);
List<(int Nominal, int Count)> answers = new();
for (int i = nominals.Length - 1; i >= 0; i--)
{
    int count = S / nominals[i];
    S -= count * nominals[i];

    if(count > 0)
    {
        answers.Add((nominals[i], count));
    }
}

if (S > 0)
{
    Console.WriteLine("No solution");
}
else
{
    int totalCoins = answers.Sum(item => item.Count);
    Console.WriteLine(totalCoins);
    foreach (var item in answers)
    {
        Console.WriteLine($"{item.Nominal} x {item.Count}");
    }
}
