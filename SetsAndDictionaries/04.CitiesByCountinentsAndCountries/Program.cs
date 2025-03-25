using System.Numerics;

namespace _04.CitiesByCountinentsAndCountries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> world = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!world.ContainsKey(continent))
                {
                    world.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!world[continent].ContainsKey(country))
                {
                    world[continent].Add(country, new List<string>());
                }
                world[continent][country].Add(city);
            }
            
              //Europe Bulgaria Sofia
             //Asia China Beijing
             //Asia Japan Tokyo
             //Europe Poland Warsaw
             //Europe Germany Berlin
             //Europe Poland Poznan
             //Europe Bulgaria Plovdiv
             //Africa Nigeria Abuja
             //Asia China Shanghai


            foreach (var continent in world)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
