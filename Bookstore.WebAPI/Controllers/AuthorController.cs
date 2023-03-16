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
        private static AuthorService _AuthorService { get; set; } = new AuthorService();

        [HttpGet]
        public List<Author> Get()
        {
            
            return _AuthorService.GetAuthors();
        }

        [HttpPost]
        public Author Add(Author author)
        {
            _AuthorService.Add(author);
            return author;
        }

    }
}
