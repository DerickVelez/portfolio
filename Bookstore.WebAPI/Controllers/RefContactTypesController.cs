using Bookstore.Data.Entitites;
using Bookstore.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefContactTypesController : ControllerBase
    {
        private static RefContactTypesService _RefContactTypesService { get; set; } = new RefContactTypesService();


        [HttpGet]
        public List<RefContactTypes> Get()
        {
          
            return _RefContactTypesService.GetRefContactTypes();
        }
         
        [HttpPost]

        public RefContactTypes Add(RefContactTypes refcontacttypes)
        {
            _RefContactTypesService.Add(refcontacttypes);
            return refcontacttypes;

        }
    }
}
