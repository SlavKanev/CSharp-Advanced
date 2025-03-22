namespace _3.MaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] ints = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = ints[col];
                }
            }
            int maxSum = 0;
            int startRowIndex = 0;
            int startColIndex = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                int currMax = 0;
                
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    currMax = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currMax > maxSum)
                    {
                        maxSum = currMax;
                        startRowIndex = row;
                        startColIndex = col;
                        currMax = 0;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = startRowIndex; row < startRowIndex +3; row++)
            {
                for (int col = startColIndex; col < startColIndex + 3; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
