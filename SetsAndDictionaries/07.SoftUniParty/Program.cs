namespace _07.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            while (input!= "PARTY")
            {
                char firstChar = input[0];
                
                if (char.IsDigit(firstChar))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }

                    input = Console.ReadLine();
            }
            input= Console.ReadLine();
            while (input!= "END")
            {
                if (char.IsDigit(input[0]))
                {
                    vip.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }


                input = Console.ReadLine();
            }
            int totalPeople = vip.Count + regular.Count;

            Console.WriteLine(totalPeople);
            foreach (var people in vip)
            {
                Console.WriteLine(people);
            }
            foreach (var reg in regular)
            {
                Console.WriteLine(reg);
            }
        }
    }
}
