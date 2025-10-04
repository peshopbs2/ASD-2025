string word = Console.ReadLine();
Dictionary<string, int> words = new Dictionary<string, int>();

int count = 1;
for(char l1 = 'a'; l1 <= 'z'; l1++)
{
    for(char l2 = 'a'; l2 <= 'z'; l2++)
    {
        if(l1 != l2)
        {
            string current = $"{l1}{l2}";
            words[current] = count;
            count++;
        }
    }
}
Console.WriteLine(words[word]);
