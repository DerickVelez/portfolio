﻿using Bookstore.Data.Entitites;
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
    private List<Books> booksList = new List<Books>();
    private string connectionString;
    public BooksService(string connectionString)
    {
        this.connectionString = connectionString;
    }

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

        var createdAuthor = con.QuerySingle<Books>("INSERT INTO Books (ISBN,BookTitle,PublicationDate,BookComment) " +
            "OUTPUT INSERTED.BookID, INSERTED.ISBN, INSERTED.BookTitle,                                                                                                                 INSERTED.PublicationDate, INSERTED.BookComment VALUES (@ISBN,@BookTitle,@PublicationDate,@BookComment);", books);
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

        var createdAuthor = con.Execute("UPDATE Books SET ISBN = @ISBN, BookTitle = @BookTitle, " +
            "PublicationDate = @PublicationDate WHERE (BookID = @BookID)", book);
        return book;

    }

    public Books? FindById(int bookId)
    {
        return booksList.Where(a => a.BookID == bookId).FirstOrDefault();
    }
};

 