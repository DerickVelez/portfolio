using Bookstore.Data.Entitites;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service;

public class BooksService
{
    private List<Books> booksList = new List<Books>
    {
        //new Books
        //{
        //    BookID = 1,
        //    ISBN = 23465,
        //    BookTitle = "bokbok",
        //    PublicationDate = new DateTime(2022, 10, 2),
        //    BookComment = "no comment",
        //    AuthorID = 1,

        //}

    };
    public string connectionString = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

    public bool IsAlreadyExist(int bookID, int authorID)
    {
        var alreadyexist = booksList.Where(a => a.BookID == bookID && a.AuthorID == authorID).FirstOrDefault();
        return alreadyexist != null;
    }

    public List<Books> GetBooks()
    {
    
        using var con = new SqlConnection(connectionString);
        con.Open();

        var books = con.Query<Books>("SELECT * FROM Books");


        return books.ToList(); 
    }

    public Books Add(Books books)
    {
        using var con = new SqlConnection(connectionString);
        con.Open();

        var createdAuthor = con.QuerySingle<Books>("INSERT INTO Books (ISBN,BookTitle,PublicationDate,BookComment) OUTPUT INSERTED.BookID, INSERTED.ISBN, INSERTED.BookTitle,                                                                                                                 INSERTED.PublicationDate, INSERTED.BookComment VALUES (@ISBN,@BookTitle,@PublicationDate,@BookComment);", books);
        return createdAuthor;

    }

    public Books Delete(Books book)
    {
       
        using var con = new SqlConnection(connectionString);
        con.Open();

        var createdAuthor = con.Execute("DELETE FROM Books WHERE (BookID = @BookID)", book);
        return book;

    }

    public Books Update(Books book)
    {
        
        using var con = new SqlConnection(connectionString);
        con.Open();

        var createdAuthor = con.Execute("UPDATE Books SET ISBN = @ISBN, BookTitle = @BookTitle, PublicationDate = @PublicationDate WHERE (BookID = @BookID)", book);
        return book;

    }

    public Books? FindById(int bookId)
    {
        return booksList.Where(a => a.BookID == bookId).FirstOrDefault();
    }
};

 