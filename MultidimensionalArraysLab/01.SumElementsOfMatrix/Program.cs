namespace _01.SumElementsOfMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowNumbers = Console.ReadLine()
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowNumbers[col];
                }
            }

            int sumOfRows = 0;
            int sumOfColumns = 0;
            int sumOfAllElements = 0;
            int currSumOfColumns = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                currSumOfColumns = 0;
                sumOfRows++;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    currSumOfColumns++;
                    sumOfAllElements += matrix[row, col];
                }
                if (currSumOfColumns > sumOfColumns)
                {
                    sumOfColumns = currSumOfColumns;
                }

            }
            Console.WriteLine(sumOfRows);
            Console.WriteLine(sumOfColumns);
            Console.WriteLine(sumOfAllElements);
        }
    }
}
