int Binom(int n, int k)
{
    if(n == k || k == 0) {  return 1; }
    return Binom(n - 1, k) + Binom(n - 1, k - 1); 
}

int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());

Console.WriteLine(Binom(n, k));
