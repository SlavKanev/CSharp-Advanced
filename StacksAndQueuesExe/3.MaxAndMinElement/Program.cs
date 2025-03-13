namespace _3.MaxAndMinElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int commandNumber = input[0];
                if (commandNumber == 1)
                {
                    int elementToPush = input[1];
                    stack.Push(elementToPush);
                }

                else if (commandNumber == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }

                else if (commandNumber == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (commandNumber == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
