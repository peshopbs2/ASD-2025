class Program
{
    private static int[] path;
    private static int[] countReel;

    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());

        int[] reelLengths = new int[M];
        for (int i = 0; i < M; i++)
        {
            reelLengths[i] = int.Parse(Console.ReadLine());
        }

        string command = Console.ReadLine();
        int[] dp = new int[N + 1];
        path = new int[N + 1];

        for (int i = 1; i <= N; i++)
        {
            dp[i] = int.MaxValue;
        }

        dp[0] = 0;



        for (int j = 1; j <= N; j++)
        {
            for (int i = 0; i < M; i++)
            {
                if (j - reelLengths[i] >= 0)
                {
                    if (dp[j - reelLengths[i]] + 1 < dp[j])
                    {
                        dp[j] = dp[j - reelLengths[i]] + 1;
                        path[j] = reelLengths[i];
                    }
                }
            }
        }


        if (command == "count")
        {
            Console.WriteLine(dp[N] == int.MaxValue ? 0 : dp[N]);
        }
        else if (command == "details")
        {
            var reelCounts = new Dictionary<int, int>();


            int currentTime = N;
            while (currentTime > 0)
            {
                int reelLength = path[currentTime];
                if (reelLength == 0) break;

                if (reelCounts.ContainsKey(reelLength))
                {
                    reelCounts[reelLength]++;
                }
                else
                {
                    reelCounts[reelLength] = 1;
                }

                currentTime -= reelLength;
            }


            foreach (var reel in reelCounts.OrderByDescending(r => r.Key))
            {
                Console.WriteLine($"{reel.Value} x {reel.Key} seconds");
            }
        }
    }
}
