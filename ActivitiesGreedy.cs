int n = int.Parse(Console.ReadLine()); //брой дейности
List<(string Name, int Start, int End)> activities = new();
for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split();
    string name = data[0];
    int start = int.Parse(data[1]);
    int end = int.Parse(data[2]);
    activities.Add((name, start, end));
}
activities = activities
    .OrderBy(item => item.End)
        .ThenBy(item => item.Start)
    .ToList();
List<(string Name, int Start, int End)> solution = new();
(string Name, int Start, int End) lastTaken = activities[0];
solution.Add(lastTaken);
foreach (var activity in activities)
{
    if(lastTaken.End <= activity.Start)
    {
        solution.Add(activity);
        lastTaken = activity;
    }
}

foreach (var activity in solution)
{
    Console.WriteLine($"{activity.Name} {activity.Start} {activity.End}");
}
