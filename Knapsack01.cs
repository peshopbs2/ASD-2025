public class Item
{
  public int Price { get; set; }
  public int Weight { get; set; }
}


int elements = int.Parse(Console.ReadLine());
List<Item> items = new List<Item>();
for (int i = 0; i < elements; i++)
{
    Console.WriteLine("Enter price: ");
    int price = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter weight: ");
    int weight = int.Parse(Console.ReadLine());
    Item item = new Item() { Price = price, Weight = weight };
    items.Add(item);
}

int capacity = int.Parse(Console.ReadLine());

int[,] dp = new int[elements + 1, capacity + 1];
//dp[i, j] ни казва каква е макс печалба за раница с капацитет j, при положение, че имаме право да ползваме елементи само от 0 до i
for (int cap = 0; cap <= capacity; cap++)
{
    dp[0, cap] = (items[0].Weight <= cap ? items[0].Price : 0);
}

for(int i = 1; i < elements; i++)
{
    for (int j = 0; j <= capacity; j++)
    {
        if (items[i].Weight <= j)
        {
            dp[i, j] = Math.Max(dp[i - 1, j],
                dp[i - 1, j - items[i].Weight] + items[i].Price);
        }
        else
        {
            dp[i, j] = dp[i - 1, j];
        }
    }
}

Console.WriteLine(dp[elements - 1, capacity]);
