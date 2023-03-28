using Bookstore.Data.Entitites;
using Bookstore.Service.DTO.Author;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service
{
    public class AuthorService
    {

        private static
            List<Author> authorList = new List<Author>
        {
            new Author
            {
                FirstName = "Alvin",
                LastName = "Almodal",
                AuthorID = 1
            },
            new Author
            {
                FirstName = "Diane",
                LastName = "Almodal",
                AuthorID = 2
            }
        };
        //function fot no duplicates
        public bool IsAlreadyRegistered(string firstName,string lastName)
        {
            var author = authorList.Where(
                x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault();
           return author != null;
        }

        public List<Author> GetAuthors()
        {
            var cs = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var authors = con.Query<Author>("SELECT * FROM Authors");
            return authors.ToList();
        }

        public CreateAuthorRequest Add(CreateAuthorRequest request)
        {
            var cs = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var createdAuthor = con.QuerySingle<CreateAuthorRequest>("INSERT INTO Authors (FirstName,LastName) OUTPUT INSERTED.AuthorID, INSERTED.FirstName, INSERTED.LastName VALUES (@FirstName,@LastName);",request);
            return createdAuthor;
        }

        public RemoveAuthorResponse DeleteAuthor(RemoveAuthorResponse request)
        {
            var cs = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var createdAuthor = con.Execute("DELETE FROM Authors WHERE (AuthorID = @AuthorID)", request);
            return request;
        }

        public UpdateAuthorRequests Update(UpdateAuthorRequests request)
        {
            var cs = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var createdAuthor = con.Execute("UPDATE Authors SET FirstName = @FirstName, LastName = @LastName WHERE (AuthorID = @AuthorID)", request);
            return request;
        }

        public Author? FindById(int authorId)
        {
            return authorList.Where(a => a.AuthorID == authorId).FirstOrDefault();
        }
    }
}
    