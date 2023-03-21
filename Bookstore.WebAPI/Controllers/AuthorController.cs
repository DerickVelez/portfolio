 using Bookstore.Data.Entitites;
using Bookstore.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private static AuthorService _AuthorService = new AuthorService();

        [HttpGet]
        public List<Author> Get() 
        {
           return _AuthorService.GetAuthors();
        }

            

        [HttpPost]
        public ActionResult<Author> Add(Author author)
        {
            bool alreadyExist = _AuthorService.IsAlreadyRegistered(author.FirstName, author.LastName);
            if (alreadyExist)
            {
                return BadRequest("User Already Exist");
            }    
            else
            _AuthorService.Add(author);
            return author;
        }

        [HttpPut]
        public Author Update(Author author)
        {
            _AuthorService.Update(author);
            return author;
        }
        [HttpDelete]

        public Author Delete(Author author)
        {
            _AuthorService.DeleteAuthor(author);
            return author;
        }
        
    }
}
