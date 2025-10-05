class Program
{
    private static int[] sizes;
    private static int rows;
    private static int cols;
    private static int[,] arr;
    static void Fill(int row, int col)
    {
        if (row < 0 || row >= rows || col < 0 || col >= cols || arr[row, col] == 0 || arr[row, col] == 2)
        {
            //ако излизаме от матрицата, то сме стигнали дъно на рекурсията
            //или ако няма пожар, то сме стигнали дъно на рекурсията
            //или вече сме минали през това поле и сме потвърдили, че е част от огнището
            return;
        }

        arr[row, col] = 2;
        Fill(row - 1, col); //нагоре
        Fill(row - 1, col + 1); //нагоре, надясно
        Fill(row, col + 1); //надясно
        Fill(row + 1, col + 1); //надолу, надясно
        Fill(row + 1, col); //надолу
        Fill(row + 1, col - 1); //надолу, наляво
        Fill(row, col - 1); //наляво
        Fill(row - 1, col - 1); //нагоре, наляво
    }

    static void Main(string[] args)
    {
        sizes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        rows = sizes[0];
        cols = sizes[1];
        arr = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            int[] data = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = data[j];
            }
        }

        int count = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (arr[i, j] == 1)
                {
                    Fill(i, j);
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}
