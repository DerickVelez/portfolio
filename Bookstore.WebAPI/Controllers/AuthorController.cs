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
        public List<Data.Entitites.Author> Get() 
        {
           return _AuthorService.GetAuthors();
        }

            

        [HttpPost]
        public ActionResult<CreateAuthorResponse> Add(Service.DTO.Author.Author request)
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
        public Data.Entitites.Author Update(Data.Entitites.Author author)
        {
            _AuthorService.Update(author);
            return author;
        }
        [HttpDelete]

        public Data.Entitites.Author Delete(Data.Entitites.Author author)
        {
            _AuthorService.DeleteAuthor(author);
            return author;
        }
        
    }
}
