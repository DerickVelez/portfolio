using Bookstore.Data.Entitites;
using Bookstore.Service.DTO.Author;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service;

public class AuthorService
{

    private static List<Author> authorList = new List<Author>();

    private string connectionString;

    public AuthorService(string connectionString)
    {       
        this.connectionString = connectionString;
    }

    public bool IsAlreadyRegistered(string firstName,string lastName)
    {
        var author = authorList.Where(
            x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault();
       return author != null;
    }

    public List<Author> GetAuthors()
    {
        using var con = new SqlConnection(connectionString);
        con.Open();

        var authors = con.Query<Author>("SELECT * FROM Authors");
        return authors.ToList();
    }

    public CreateAuthorRequest Add(CreateAuthorRequest request)
    {
        using var con = new SqlConnection(connectionString);
        con.Open();

        var createdAuthor = con.QuerySingle<CreateAuthorRequest>(
            "INSERT INTO Authors (FirstName,LastName)" +
            " OUTPUT INSERTED.AuthorID, INSERTED.FirstName, INSERTED.LastName" +
            " VALUES (@FirstName,@LastName);",request);
        return createdAuthor;
    }

    public RemoveAuthorRequest DeleteAuthor(RemoveAuthorRequest request)
    {
        using var con = new SqlConnection(connectionString);
        con.Open();

        var createdAuthor = con.Execute("DELETE FROM Authors WHERE (AuthorID = @AuthorID)", request);
        return request;
    }

    public UpdateAuthorRequests Update(UpdateAuthorRequests request)
    {
        using var con = new SqlConnection(connectionString);
        con.Open();

        var createdAuthor = con.Execute("UPDATE Authors SET FirstName = @FirstName," +
            " LastName = @LastName WHERE (AuthorID = @AuthorID)", request);
        return request;
    }

    public Author? FindById(int authorId)
    {
        return authorList.Where(a => a.AuthorID == authorId).FirstOrDefault();
    }
}
