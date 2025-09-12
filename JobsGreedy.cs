int n = int.Parse(Console.ReadLine());
List<(int Id, int Deadline, int Value)> jobs = new();
for (int i = 0; i < n; i++)
{
    int[] data = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    jobs.Add((Id: data[0], Deadline: data[1], Value: data[2]));
}

jobs = jobs
    .OrderByDescending(item => item.Value)
    .ToList();
List<(int Id, int Deadline, int Value)> solutions = new();
(int Id, int Deadline, int Value) lastTaken = jobs[0];
solutions.Add(lastTaken);
foreach (var job in jobs)
{
    if(job.Deadline > lastTaken.Deadline)
    {
        solutions.Add(job);
        lastTaken = job;
    }
}
List<int> solutionIds = solutions
    .Select(item => item.Id)
    .ToList();
Console.WriteLine(string.Join(" ", solutionIds));
int maxValue = solutions.Sum(item => item.Value);
Console.WriteLine(maxValue);
