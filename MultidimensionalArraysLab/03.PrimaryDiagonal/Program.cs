namespace _03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];
            int diagonal = 0;
            for (int row = 0; row < size; row++)
            {
                int[] ints = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = ints[col];
                    if (row == col)
                    {
                        diagonal += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(diagonal);
        }
    }
}
