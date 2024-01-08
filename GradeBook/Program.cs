using System;

namespace GradeBook
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();

            var grades = new List<double>();
            grades.Add(56.1);
            grades.Add(52.1);
            grades.Add(90.1);

            var result = 0.0;
            foreach (var grade in grades)
            {
                result += grade;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is: {result}");

            if (args.Length > 0) {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else { Console.WriteLine("Hello!"); }
        }
    }
}