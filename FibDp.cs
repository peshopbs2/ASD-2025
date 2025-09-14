int n = int.Parse(Console.ReadLine());
int[] dp = new int[n + 1];
dp[1] = 1;
dp[2] = 1;
for (int i = 2; i <= n; i++)
{
    dp[i] = dp[i - 1] + dp[i - 2];
}

Console.WriteLine(dp[n]);
