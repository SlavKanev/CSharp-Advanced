namespace _02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] ints = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = ints[col];
                }
            }
            //3, 6
            //7 1 3 3 2 1
            //1 3 9 8 5 6
            //4 6 7 9 1 0
            Queue<int> queue = new Queue<int>();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currSum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    currSum += matrix[row, col];
                }
                queue.Enqueue(currSum);
            }

            foreach (var sum in queue)
            {
                Console.WriteLine(sum);
            }

        }
    }
}
