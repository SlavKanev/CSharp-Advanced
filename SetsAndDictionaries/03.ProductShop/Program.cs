namespace _03.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, decimal>> shopSystem = new Dictionary<string, Dictionary<string, decimal>>();
            while (input!= "Revision")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = tokens[0];
                string product = tokens[1];
                decimal price = decimal.Parse(tokens[2]);
                if (!shopSystem.ContainsKey(shop))
                {
                    shopSystem.Add(shop, new Dictionary<string, decimal>());
                }
                shopSystem[shop].Add(product, price);


                input = Console.ReadLine();
            }

            foreach (var shop in shopSystem.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{shop.Key} ->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value:f1}");
                }
            }
        }
    }
}
