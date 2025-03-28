namespace _2.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = inputNumbers[0];
            int m = inputNumbers[1];
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int currElement = int.Parse(Console.ReadLine());
                first.Add(currElement);
            }
            for (int i = 0; i < m; i++)
            {
                int currElement = int.Parse(Console.ReadLine());
                second.Add(currElement);
            }

            foreach (var num in first)
            {
                foreach (var number in second)
                {
                    if (num == number)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
        }
    }
}
