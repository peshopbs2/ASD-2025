

class Program
{
    private static readonly Stack<char> solution = new();
    static void Main()
    {
        int[] sizes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int rows = sizes[0];
        int cols = sizes[1];
        char[,] board = new char[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < cols; j++)
            {
                board[i, j] = line[j];
            }
        }

        Solve(board, 0, 0);
    }

    private static void Solve(char[,] board, int row, int col)
    {
        if(!(row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1)))
        {
            solution.Pop();
            return;
        }

        if (board[row, col] == '*' || board[row, col] == 'x')
        {
            solution.Pop();
            return;
        }

        if (board[row, col] == 'e')
        {
            Print(board);
            return;
        }

        board[row, col] = 'x';
        solution.Push('R');
        Solve(board, row, col + 1); //R
        solution.Push('D');
        Solve(board, row + 1, col); //D
        solution.Push('U');
        Solve(board, row - 1, col); //U
        solution.Push('L');
        Solve(board, row, col - 1); //L
        board[row, col] = '-';
    }

    private static void Print(char[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write($"{board[i, j],3}");
            }
            Console.WriteLine();
        }
        Console.WriteLine(string.Join(" ", solution));
        solution.Clear();
        Console.WriteLine("----------------------------");
    }
}
