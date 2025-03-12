namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            int passed = 0;
            Queue<string> queue = new Queue<string>();
            while (line!= "end")
            {
                if (line == "green")
                {
                    if (queue.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            passed ++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < queue.Count; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            passed ++;
                            i--;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(line);
                }

                    line = Console.ReadLine(); 
            }
            Console.WriteLine($"{passed} cars passed the crossroads.");
        }
    }
}
