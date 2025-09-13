using System.Numerics;

class Program
{
    static BigInteger[] fib;

    static BigInteger Fib(int n)
    {
        if (fib[n] != 0)
        {
            return fib[n];
        }
        fib[n] = Fib(n - 1) + Fib(n - 2);
        return fib[n];
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        fib = new BigInteger[n + 1];
        fib[1] = 1;
        fib[2] = 1;
        Console.WriteLine(Fib(n));
    }
}
