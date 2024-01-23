using System.Diagnostics;

namespace GradeBook.Tests
{
    public class BookTests
    {

        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book("Grade Book");

            book.AddGrade(89.1);
            book.AddGrade(56.1);
            book.AddGrade(52.1);
            book.AddGrade(90.1);

            // act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(71.85, result.Average, 1);
            Assert.Equal(90.1, result.High, 1);
            Assert.Equal(52.1, result.Low, 1);
        }
    }
}