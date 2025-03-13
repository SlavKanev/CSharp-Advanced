using System.Text;

namespace _9.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = line[0];

                if (command == "1")
                {
                    stack.Push(sb.ToString());
                    sb.Append(line[1]);
                }
                else if (command == "2")
                {
                    stack.Push(sb.ToString());
                    int count = int.Parse(line[1]);

                    while (count > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                        count--;
                    }
                }
                else if (command == "3")
                {
                    int element = int.Parse(line[1]);
                    Console.WriteLine(sb[element - 1]);

                }
                else
                {
                    sb.Clear();
                    sb.Append(stack.Pop());
                }
            }

        }
    }
}
