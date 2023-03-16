using Bookstore.Data.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service
{
    public class BooksServices
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


        public void Add(Books books)
        {
            booksList.Add(books);
        }

        public void Delete(Books books)
        {
            booksList.Remove(books);
        }

        public void Update(Books books)
        {
            var selectedBooks = booksList.Where(a => a.BookID == books.BookID).FirstOrDefault();
            selectedBooks = books;
        }

        public Books? FindById(int bookId)
        {
            return booksList.Where(a => a.BookID == bookId).FirstOrDefault();
        }
    };

}
