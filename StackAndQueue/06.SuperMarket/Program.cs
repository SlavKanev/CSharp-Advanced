namespace _06.SuperMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> customers = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    foreach (var name in customers)
                    {
                        Console.WriteLine(name);
                    }
                    customers.Clear();
                }
                else
                {
                    customers.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            if (customers.Count > 0)
            {
                Console.WriteLine($"{customers.Count} people remaining.");
            }
        }
    }
}
