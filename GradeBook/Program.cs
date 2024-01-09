using System;
using System.Xml.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(56.1);
            book.AddGrade(52.1);
            book.AddGrade(90.1);

            var stats = book.GetStatistics();

            //Console.WriteLine($"For the book: {name}");
            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The average grade is: {stats.Average}");
        }
    }
}