void Print(int x)
{
    if(x <= 0)
    {
        return;
    }

    Console.WriteLine(x);
    //before recursion
    Print(x - 1);
    //after - when returning
}

Print(10);
