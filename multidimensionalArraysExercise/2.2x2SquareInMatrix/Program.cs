namespace _2._2x2SquareInMatrix
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

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = char.Parse(line[col]);
                }
            }

            int squaresSum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char currElement = matrix[row, col];
                    char rightElement = matrix[row, col + 1];
                    char underElement = matrix[row + 1, col];
                    char diagonalElement = matrix[row + 1, col+1];
                    if (currElement == rightElement && underElement == diagonalElement && currElement == underElement)
                    {
                        squaresSum++;
                    }
                }
            }
            Console.WriteLine(squaresSum);
        }
    }
}
