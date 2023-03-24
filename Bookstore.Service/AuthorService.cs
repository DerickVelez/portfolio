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

        public CreateAuthorResponse Add(CreateAuthorRequest request)
        {
            var cs = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            //var addauthor = con.Execute("INSERT INTO Authors (FirstName,LastName)  VALUES (@FirstName,@LastName)",author);

            var createdAuthor = con.QuerySingle<CreateAuthorResponse>("INSERT INTO Authors (FirstName,LastName) OUTPUT INSERTED.AuthorID, INSERTED.FirstName, INSERTED.LastName VALUES (@FirstName,@LastName);"
        ,request);

            return createdAuthor;
        }

        public List<Author> DeleteAuthor(Author author)
        {
                authorList =  authorList.Where(a => a.AuthorID != author.AuthorID).ToList() ;
            return authorList;
             
        }

        public void Update(Author author)
        {
            var selectedAuthor = authorList.Where(
                a => a.AuthorID == author.AuthorID).FirstOrDefault();
            authorList.Remove(selectedAuthor);
            authorList.Add(author);
        }
        public Author? FindById(int authorId)
        {
            return authorList.Where(a => a.AuthorID == authorId).FirstOrDefault();
        }
    }
}
    