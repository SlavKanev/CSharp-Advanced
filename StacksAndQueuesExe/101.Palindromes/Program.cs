namespace _101.Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aAlinNilaA gabiIbag mama


            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);



            string[] inputToLower = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inputToLower[i] = input[i].ToLower();
            }

            foreach (var word in inputToLower)
            {
                bool isPalidrome = CheckIfWordIsPalindrome(word);

                if (isPalidrome)
                {
                    Console.WriteLine($"Word: {word} is palindrome!");
                }
            }
        }

        static bool CheckIfWordIsPalindrome(string word)
        {
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            foreach (var ch in word)
            {
                stack.Push(ch);
                queue.Enqueue(ch);

            }
            while (stack.Count > 0 && queue.Count > 0)
            {
                char currStackChar = stack.Pop();
                char currQueueChar = queue.Dequeue();
                if (currStackChar != currQueueChar)
                {
                    return false;
                }

            }

            return true;

        }
    }
}
