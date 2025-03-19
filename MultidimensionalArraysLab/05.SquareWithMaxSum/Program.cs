namespace _05.SquareWithMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] ints = Console.ReadLine()
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = ints[col];
                }
            }

            //Queue<int[,]> queue = new Queue<int[,]> ();
            int maxSum = 0;
            int[,] currMatrix = new int[2, 2];
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int currElement = matrix[row,col];
                    int currRightElement = matrix[row,col +1];
                    int currDownElement = matrix[row + 1,col];
                    int currDiagonalElement = matrix[row + 1,col +1];
                    int currSum = currElement + currRightElement + currDownElement + currDiagonalElement;
                    if (currSum > maxSum)
                    {
                        currMatrix[0,0] = currElement;
                        currMatrix[0, 1] = currRightElement;
                        currMatrix[1, 0] = currDownElement;
                        currMatrix[1, 1] = currDiagonalElement;
                        //queue.Enqueue (currMatrix);
                        maxSum = currSum;
                    }
                }
            }
            
            for (int row = 0; row < currMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < currMatrix.GetLength(1); col++)
                {
                    Console.Write(currMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
