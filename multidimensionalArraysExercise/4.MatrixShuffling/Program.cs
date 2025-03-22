namespace _4.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = sizes [0];
            int cols = sizes [1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] strings = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = strings[col];
                }
            }

            string input = Console.ReadLine();
            
            while (input != "END")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArgs [0];
                if (command != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int oldRowValue = int.Parse(inputArgs [1]);
                    int oldColValue = int.Parse(inputArgs [2]);
                    int newRowValue = int.Parse(inputArgs [3]);
                    int newColValue = int.Parse(inputArgs [4]);

                    if (oldRowValue < 0 || oldColValue <0 || newRowValue <0 || newColValue <0 
                        || oldRowValue > matrix.GetLength(0) -1 || oldColValue > matrix.GetLength(1) - 1
                        || newRowValue > matrix.GetLength(0) - 1 || newColValue > matrix.GetLength(1) -1)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string oldValue = matrix[oldRowValue, oldColValue];
                        matrix[oldRowValue, oldColValue] = matrix[newRowValue, newColValue];
                        matrix[newRowValue, newColValue] = oldValue;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row,col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }

                }



                    input = Console.ReadLine();
            }
        }
    }
}
