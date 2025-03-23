namespace _6.JaggedArrayManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                int[] ints = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jagged[i] = ints;


            }
            for (int row = 0; row < jagged.Length - 1; row++)
            {

                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] *= 2;
                    }
                    for (int j = 0; j < jagged[row + 1].Length; j++)
                    {
                        jagged[row + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] /= 2;
                    }
                    for (int j = 0; j < jagged[row + 1].Length; j++)
                    {
                        jagged[row + 1][j] /= 2;
                    }
                }

            }
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArgs[0];
                int row = int.Parse(inputArgs[1]);
                int col = int.Parse(inputArgs[2]);
                int value = int.Parse(inputArgs[3]);

                if (CheckIfIndexesAreCorrectly(jagged, row, col))
                {
                    if (command == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (command == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }



                input = Console.ReadLine();
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                foreach (var item in jagged[i])
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        static bool CheckIfIndexesAreCorrectly(int[][] jagged, int row, int col)
        {

            if (row >= 0 && row <= jagged.Length && col >=0 && col <= jagged[row].Length)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
