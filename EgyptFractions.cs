int GCD(int x, int y)
{
    while(x != y)
    {
        if(x > y) { x -= y; }
        else { y -= x; }
    }
    return x;
}

int p = int.Parse(Console.ReadLine());
int q = int.Parse(Console.ReadLine());

while(p != 1)
{
    int r = (p + q) / p; //следващ знаменател
    Console.WriteLine($"1 / {r}");
    p = p * r - q; //общ знаменател заради изваждането p/q - 1 /r
    q = q * r; //общ знаменател !
    int div = GCD(p, q); //на колко да делим, за да съкратим?
    p /= div; //съкращаваме
    q /= div; //тук също
}
Console.WriteLine($"1 / {q}");
