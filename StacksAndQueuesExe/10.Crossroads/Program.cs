namespace _10.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int green = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int crossed = 0;
            Queue<string> queue = new Queue<string>();
            bool crashed = false;
            while (command != "END")
            {

                if (command == "green")
                {
                    int timeLeft = green;
                    while (timeLeft > 0 && queue.Count > 0)
                    {
                        string currCar = queue.First();

                        if (timeLeft + freeWindow > currCar.Length)
                        {
                            queue.Dequeue();
                            crossed++;
                            timeLeft -= currCar.Length;
                        }

                        else
                        {
                            if (timeLeft + freeWindow > currCar.Length)
                            {
                                queue.Dequeue();
                                crossed++;
                                timeLeft -= currCar.Length;
                            }
                            else
                            {
                                int indexOfCrash = timeLeft + freeWindow;
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{queue.First()} was hit at {queue.First()[indexOfCrash]}.");
                                crashed = true;
                                return;

                            }
                        }

                    }


                }
                else
                {
                    queue.Enqueue(command);
                }



                command = Console.ReadLine();
            }

            if (crashed == false)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{crossed} total cars passed the crossroads.");
            }

        }
    }
}
