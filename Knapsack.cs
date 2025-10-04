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

int[] dp = new int[capacity + 1];
dp[0] = 0;
for (int i = 1; i <= capacity; i++)
{
    foreach (var item in items)
    {
        if(i - item.Weight >= 0)
        {
            dp[i] = Math.Max(
                dp[i-item.Weight] + item.Price,
                dp[i]);
        }
    }
}
Console.WriteLine(dp[capacity]);
