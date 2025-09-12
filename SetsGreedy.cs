
List<int> universe = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int n = int.Parse(Console.ReadLine());
List<List<int>> sets = new();
for (int i = 0; i < n; i++)
{
    List<int> set = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();
    sets.Add(set);
}

sets = sets
    .OrderByDescending(item => item.Count())
    .ToList();

foreach (var set in sets)
{
    if(HasCommon(universe, set))
    {
        Console.WriteLine(string.Join(" ", set));
        foreach (var item in set)
        {
            universe.Remove(item);
        }
    }
}

bool HasCommon(List<int> universe, List<int> set)
{
    foreach (var item in set)
    {
        if (universe.Contains(item))
        {
            return true;
        }
    }
    return false;
}
