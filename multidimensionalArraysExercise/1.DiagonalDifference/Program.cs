namespace _1.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size,size];

            for (int row = 0; row < size; row++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col]  = inputNumbers[col];
                }
            }

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == col)
                    {
                        primaryDiagonalSum += matrix[row, col];
                    }
                    if (row + col == size - 1)
                    {
                        secondaryDiagonalSum += matrix[row,col];
                    }
                }
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));

        }
    }
}
