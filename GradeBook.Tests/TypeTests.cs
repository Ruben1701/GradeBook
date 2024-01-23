using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }


        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.name);
        }

        private void SetName(Book book, string name)
        {
            book.name = name;
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
