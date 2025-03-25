namespace _01.Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double,int> dictionary = new Dictionary<double,int>();

            for (int i = 0; i < input.Length; i++)
            {
                double currNumber = input[i];

                if (!dictionary.ContainsKey(currNumber))
                {
                    dictionary.Add(currNumber,1);
                }
                else
                {
                    dictionary[currNumber]++;
                }
            }
            foreach (var number in dictionary)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }

            
            

        }
    }
}
