namespace _3.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> strings = new HashSet<string>();
            SortedSet<string> sorted = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < input.Length; j++)
                {
                    string element = input[j];
                    strings.Add(element);
                    sorted.Add(element);
                }
            }
            //Console.WriteLine("HashSet:");
            //Console.WriteLine(string.Join(" ",strings));
            //Console.WriteLine("Sorted:");
            //Console.WriteLine(string.Join(" ",sorted));
            //Console.WriteLine("HashSet after orderBy:");
            foreach (var element in strings.OrderBy(x=>x))
            {
                Console.Write(element + " ");
            }

        }
    }
}
