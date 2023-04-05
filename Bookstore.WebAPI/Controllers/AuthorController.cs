using Bookstore.Data.Entitites;
using Bookstore.Service;
using Bookstore.Service.DTO.Author;

using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
 
public class AuthorController : ControllerBase
{
    private static AuthorService _AuthorService;

    public AuthorController(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DerickServer");
        //var connectionString = configuration.GetSection("HuwowConnectionString:DerickServer").Value.ToString();
        //_AuthorService = new AuthorService("Server=DESKTOP-F3KVDMV\\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;");
        _AuthorService = new AuthorService(connectionString);
    }

    [HttpGet]
    public List<Author> Get() 
    {
        return _AuthorService.GetAuthors();
    }     

    [HttpPost]
    public ActionResult<CreateAuthorRequest> Add(CreateAuthorRequest request)
    {
        bool alreadyExist = _AuthorService.IsAlreadyRegistered(request.FirstName, request.LastName);
        if (alreadyExist)
        {
            return BadRequest("User Already Exist");
        }    
        return  _AuthorService.Add(request);
    }

    [HttpPut]
    public UpdateAuthorRequests Update(UpdateAuthorRequests response)
    {
        _AuthorService.Update(response);
        return response;
    }

    [HttpDelete]
    public RemoveAuthorResponse Delete(RemoveAuthorResponse response)
    {
        _AuthorService.DeleteAuthor(response);
        return response;
    }
    
}
