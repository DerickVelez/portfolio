using Bookstore.Data.Entitites;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                AuthorID = 1,

            }

        };
        public bool IsAlreadyExist(int bookID, int authorID)
        {
            var alreadyexist = booksList.Where(a => a.BookID == bookID && a.AuthorID == authorID).FirstOrDefault();
            return alreadyexist != null;
        }

        public List<Books> GetBooks()
        {
            var cs = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var books = con.Query<Books>("SELECT * FROM Books");


            return books.ToList(); 
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
