using Bookstore.Data.Entitites;
using Bookstore.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        
        private static BooksService _BooksService{ get; set; } = new BooksService();

        [HttpGet]
        public List<Books> Get()
        {
            return _BooksService.GetBooks();
        }

        [HttpPost]

        public Books Add(Books books)
        {
            bool alreadyExist = _BooksService.IsAlreadyExist(books.BookID, books.AuthorID);
            if (alreadyExist)
                return null;
            else
            _BooksService.Add(books);
            return books;  
        }

        [HttpPut]
        public Books Update(Books books)
        {
            _BooksService.Update(books);
            return books;
        }
        [HttpDelete]

        public Books Delete(Books books)
        {
            _BooksService.Delete(books);
            return books;
        }
    }
}
