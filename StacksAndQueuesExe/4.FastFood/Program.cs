namespace _4.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int biggestOrder = 0;
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < orders.Length; i++)
            {
                queue.Enqueue(orders[i]);
            }

            for (int i = 0; i < orders.Length; i++)
            {
                int currOrder = orders[i];

                if (totalFood >= currOrder)
                {
                    totalFood -= currOrder;
                    queue.Dequeue();
                    if (currOrder > biggestOrder)
                    {
                        biggestOrder = currOrder;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(biggestOrder);
            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.Write(string.Join(", ",queue));
            }
        }
    }
}
