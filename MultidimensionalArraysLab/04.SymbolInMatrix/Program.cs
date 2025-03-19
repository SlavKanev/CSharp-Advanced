namespace _04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size,size];

            for (int row = 0; row < size; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] += line[col];
                    
                }
            }

            char element = char.Parse(Console.ReadLine());
            bool isFound = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currElement = matrix[row, col];
                    if (element == currElement)
                    {
                        Console.WriteLine($"{(row, col)}");
                        isFound = true;
                        break;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{element} does not occur in the matrix");
            }
        }
    }
}
