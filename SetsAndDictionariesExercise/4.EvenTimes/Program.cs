namespace _4.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int,int> numbers = new Dictionary<int,int>();
            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(element))
                {
                    numbers.Add(element, 0);
                }
                numbers[element]++;
            }

            foreach (var num in numbers)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                }
            }
        }
    }
}
