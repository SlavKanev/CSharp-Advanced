namespace _1.BasicStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numbersToPush = inputNums[0];
            int numbersToPop = inputNums[1];
            int searchNum = inputNums[2];
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(input);

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(searchNum))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }


        }
    }
}
