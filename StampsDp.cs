int S = int.Parse(Console.ReadLine());
int[] nominals = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] dp = new int[S + 1];
dp[0] = 0;
dp[1] = 1;
for(int i = 2; i <= S; i++)
{
    int min = int.MaxValue;
    foreach (var nominal in nominals)
    {
        if(i - nominal >= 0)
        {
            min = Math.Min(min, dp[i - nominal]);
        }
    }
    dp[i] = min + 1;
}
Console.WriteLine(dp[S]);
