int n = int.Parse(Console.ReadLine());
List<(int Id, int Length, double Probability)> programs = new();
for(int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split();
    int id = int.Parse(data[0]);
    int length = int.Parse(data[1]);
    double probability = double.Parse(data[2]);
    programs.Add((id, length, probability));
}

programs = programs
    .OrderBy(item => item.Length / item.Probability)
    .ToList();

List<int> solutionIds = programs.Select(item => item.Id).ToList();
Console.WriteLine(string.Join(" ", solutionIds));
