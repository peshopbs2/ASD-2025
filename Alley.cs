int L = int.Parse(Console.ReadLine());
int[] tiles = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] dp = new int[L + 1];
dp[0] = 1;
dp[1] = 1;
for (int i = 2; i <= L; i++)
{
    dp[i] = 0;
    foreach (var item in tiles)
    {
        if(i - item >= 0)
        {
            dp[i] += dp[i - item];
        }
    }
}

Console.WriteLine(dp[L]);
