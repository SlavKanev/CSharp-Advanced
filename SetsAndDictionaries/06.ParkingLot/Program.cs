namespace _06.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> parking = new HashSet<string>();
            while (input!= "END")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = tokens[0];
                string licensePlate = tokens[1];

                if (direction == "IN")
                {
                    parking.Add(licensePlate);
                }
                else
                {
                    parking.Remove(licensePlate);
                }

                    input = Console.ReadLine();
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
