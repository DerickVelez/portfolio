 using Bookstore.Data.Entitites;
using Bookstore.Service;
using Bookstore.Service.DTO.Author;
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
        public ActionResult<CreateAuthorResponse> Add(CreateAuthorRequest request)
        {
            bool alreadyExist = _AuthorService.IsAlreadyRegistered(request.FirstName, request.LastName);
            if (alreadyExist)
            {
                return BadRequest("User Already Exist");
            }    
           
            var response  = _AuthorService.Add(request);

            return response;
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
