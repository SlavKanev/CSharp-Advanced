namespace _03.Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<int> stack = new Stack<int>();

            int firstNum = int.Parse(inputArgs[0]);
            for (int i = 0; i < firstNum; i++)
            {
                stack.Push(1);
            }

            for (int i = 1; i < inputArgs.Length; i+=2)
            {
                string element = inputArgs[i];
                int currNum = int.Parse(inputArgs[i + 1]);
                if (element == "-")
                {
                    for (int j = 0; j < currNum; j++)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    for (int j = 0; j < currNum; j++)
                    {
                        stack.Push(1);
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum(x=>x)}");
        }
    }
}
