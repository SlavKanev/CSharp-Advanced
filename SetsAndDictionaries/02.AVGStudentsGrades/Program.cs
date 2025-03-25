namespace _02.AVGStudentsGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<double>> students = new Dictionary<string,List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }
                students[name].Add(grade);

            }
            foreach (var student in students)
            {
               string name = student.Key;
                List<double> studentGrades = student.Value;
                double average = studentGrades.Average();

                Console.Write($"{name} -> ");
                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {average:f2})");
                Console.WriteLine();
            }

        }
    }
}
