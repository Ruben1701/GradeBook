using System;

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

            book.ShowStatistics();
        }
    }
}