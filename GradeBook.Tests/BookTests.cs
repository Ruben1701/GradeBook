namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("");

            book.AddGrade(70.1);
            book.AddGrade(82.6);
            book.AddGrade(90.2);

            // act


            //assert
        }
    }
}