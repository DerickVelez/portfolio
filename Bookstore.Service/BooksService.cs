using Bookstore.Data.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service
{
    public class BooksService
    {
        private List<Books> booksList = new List<Books>
        {
            new Books
            {
                BookID = 1,
                ISBN = 23465,
                BookTitle = "bokbok",
                PublicationDate = new DateTime(2022, 10, 2),
                BookComment = "no comment",

            }

        };

        public List<Books> GetBooks()
        {
            return booksList; 
        }


        public void Add(Books book)
        {
            booksList.Add(book);
        }

        public List<Books> Delete(Books book)
        {
            booksList = booksList.Where(a => a.BookID != book.BookID).ToList();
            return booksList;
        }

        public void Update(Books book)
        {
            var selectedBooks = booksList.Where(
                a => a.BookID == book.BookID).FirstOrDefault();
            booksList.Remove(selectedBooks);
            booksList.Add(book);
        }

        public Books? FindById(int bookId)
        {
            return booksList.Where(a => a.BookID == bookId).FirstOrDefault();
        }
    };

}
