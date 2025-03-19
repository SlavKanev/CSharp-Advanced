namespace _06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] ints = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[row] = ints;
            }

            string input = Console.ReadLine();

            //int rowsOfJagged = jagged.Length;
            //int colsOfJagged = jagged[0].Length;

            while (input != "END")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = inputArgs[0];
                int row = int.Parse(inputArgs[1]);
                int col = int.Parse(inputArgs[2]);
                int value = int.Parse(inputArgs[3]);
                int jaggedLength = jagged.Length;

                if (action == "Add")
                {

                    if (jaggedLength > row && row >= 0)
                    {
                        int jaggedRowLength = jagged[row].Length;
                        if (jaggedRowLength > col && col >= 0)
                        {
                            jagged[row][col] += value;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                }
                else if (action == "Subtract")
                {
                    if (jaggedLength > row && row >= 0)
                    {
                        int jaggedRowLength = jagged[row].Length;
                        if (jaggedRowLength > col && col >= 0)
                        {
                            jagged[row][col] -= value;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }


                input = Console.ReadLine();
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
