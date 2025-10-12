int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
List<int> reels = new List<int>();
for (int i = 0; i < m; i++)
{
    int reel = int.Parse(Console.ReadLine());
    reels.Add(reel);
}

string command = Console.ReadLine();

reels = reels.OrderByDescending(item => item).ToList();

if (command == "count")
{
    int count = 0;
    while (n != 0)
    {
        foreach (var item in reels)
        {
            if(item <= n)
            {
                count += n / item;
                n -= (n / item) * item;
            }
        }
    }
    Console.WriteLine(count);
}

if(command == "details")
{
    while (n != 0)
    {
        foreach (var item in reels)
        {
            if (item <= n)
            {
                int units = n / item;
                Console.WriteLine($"{units} x {item} seconds");
                n -= units * item;
            }
        }
    }
}
