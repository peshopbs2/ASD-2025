int GCD(int a, int b)
{
    if (a == b)
    {
        return a;
    }

    return (a > b ? GCD(a - b, b) : GCD(a, b - a));
}

int LCM(int a, int b)
{
    return a * b / GCD(a, b);
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine(GCD(a, b));
Console.WriteLine(LCM(a, b));
