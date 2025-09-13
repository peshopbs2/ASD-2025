
class Program
{
    public const int N = 8;
    static bool CanPlace(int[,] board, int row, int col)
    {
        for(int i = 0; i < col; i++) //check row
        {
            if (board[row, i] == 1) { return false; }
        }

        //up left diagonal
        for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
        {
            if (board[i, j] == 1) { return false; }
        }

        //down left diagonal
        for (int i = row, j = col; i < N && j >= 0; i++, j--)
        {
            if (board[i, j] == 1) { return false; }
        }

        return true;
    }
    static void Solve(int[,] board, int col)
    {
        if(col >= N)
        {
            Print(board);
        }

        for(int i = 0; i < N; i++) //try different rows in the columns
        {
            if(CanPlace(board, i, col))
            {
                board[i, col] = 1;
                Solve(board, col + 1);
                board[i, col] = 0;
            }
        }
    }

    private static void Print(int[,] board)
    {
        for (int i = 0; i < N; i++)
        { 
            for(int j = 0; j < N; j++)
            {
                var symbol = (board[i, j] == 1 ? "Q" : ".");
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
        Console.WriteLine($"{new('-', 30)}");
    }

    static void Main()
    {
        int[,] board = new int[N, N];
        Solve(board, 0);
    }
}
