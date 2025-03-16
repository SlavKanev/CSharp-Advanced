namespace _12.CupAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupCapacity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bottleCapacity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> cups = new Queue<int>(cupCapacity);
            Stack<int> bottles = new Stack<int>(bottleCapacity);
            int wasted = 0;
            bool bottlesOut = false;
            bool cupsOut = false;
            while (cups.Count > 0 && bottles.Count > 0)
            {
                int firstCup = cups.First();
                int firstBottle = bottles.First();

                if (firstBottle >= firstCup)
                {
                    wasted += firstBottle - firstCup;
                    cups.Dequeue();
                    bottles.Pop();
                }
                else
                {
                    while (firstCup > 0)
                    {
                        if (firstBottle >= firstCup)
                        {
                            wasted += firstBottle - firstCup;
                            bottles.Pop();
                        }
                        firstCup -= firstBottle;
                        if (firstCup <= 0)
                        {
                            cups.Dequeue();
                        }
                        else
                        {
                            bottles.Pop();
                            firstBottle = bottles.First();
                            if (bottles.Count == 0)
                            {
                                bottlesOut = true;
                                break;
                            }
                        }

                    }

                }
            }
            if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ",cups)}");
            }
            if (cups.Count == 0)
            {
                int leftBottles = 0;
                foreach (var bottle in bottles)
                {
                    leftBottles += bottle;
                }
                Console.WriteLine($"Bottles: {leftBottles}");
            }
            Console.WriteLine($"Wasted litters of water: {wasted}");

        }
    }
}
