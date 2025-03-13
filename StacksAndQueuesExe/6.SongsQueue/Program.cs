using System.Text;

namespace _6.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> playlist = new Queue<string>();
            for (int i = 0; i < songs.Length; i++)
            {
                playlist.Enqueue(songs[i]);
            }
            StringBuilder stringBuilder = new StringBuilder();

            while (playlist.Count > 0)
            {
                string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = line[0];
                switch (command)
                {
                    case "Play":
                        playlist.Dequeue();
                        break;
                    case "Add":
                        for (int i = 1; i < line.Length; i++)
                        {
                            if (i != line.Length - 1)
                            {
                                stringBuilder.Append(line[i] + " ");
                            }
                            else
                            {
                                stringBuilder.Append(line[i]);
                            }
                        }
                        string song = stringBuilder.ToString();
                        stringBuilder.Clear();
                        if (playlist.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            playlist.Enqueue(song);

                        }
                            break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",playlist));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
