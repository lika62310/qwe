using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();
        Utility utility = new Utility();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book GetBook(string itemId)
        {
            Book book1 = null;
            foreach (Book book in books)
            {
                if (book.ItemId == itemId)
                    book1 = book;
            }
            return book1;

        }

        public double GetTotalValue()
        {
            double value = 0;
            foreach (Book book in books)
            {
                value += utility.GetValueOfBook(book);
            }
            return value;

        }
    }
}
