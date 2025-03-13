namespace _5.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int[] clothes = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());
            int fullCapacity = capacity;
            int racks = 0;

            for (int i = 0; i < clothes.Length; i++)
            {
                stack.Push(clothes[i]);
            }
            // 5 4 8 6 3 8 7 7 9
            // 16

            while (stack.Count > 0)
            {
                int currClothes = stack.Pop();
                if (capacity > currClothes)
                {
                    capacity -= currClothes;
                    
                }
                else if (capacity == currClothes)
                {
                    capacity -= currClothes;
                    
                    racks ++;
                }
                else
                {
                    racks++;
                    capacity = fullCapacity;
                    stack.Push(currClothes);
                }
            }

            Console.WriteLine(racks);
        }
    }
}
