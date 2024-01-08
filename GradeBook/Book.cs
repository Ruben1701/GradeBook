using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);

                result += grade;
            }
            result /= grades.Count;
            Console.WriteLine($"For the book: {name}");
            Console.WriteLine($"The highest grade is: {highGrade}");
            Console.WriteLine($"The lowest grade is: {lowGrade}");
            Console.WriteLine($"The average grade is: {result}");
        }

        private List<double> grades;
        private string name;

    }
}
