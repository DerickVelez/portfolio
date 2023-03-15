using Bookstore.Data.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service
{
    public class AuthorService
    {
        private List<Author> authorList = new List<Author>()
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

        public List<Author> GetAuthors()
        {
            return authorList;
        }

        public void Add(Author author)
        {
            authorList.Add(author);
        }

        public void Delete(Author author)
        {
            authorList.Remove(author);
        }

        public void Update(Author author)
        {
            var selectedAuthor = authorList.Where(a => a.AuthorID == author.AuthorID).FirstOrDefault();
            selectedAuthor = author;
        }
        public Author? FindById(int authorId)
        {
            return authorList.Where(a => a.AuthorID == authorId).FirstOrDefault();
        }
    }
}
