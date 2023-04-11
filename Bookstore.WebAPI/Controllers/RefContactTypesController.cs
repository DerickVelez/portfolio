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
        private static RefContactTypesService _RefContactTypesService;

        public RefContactTypesController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DerickServer");
            _RefContactTypesService = new RefContactTypesService(connectionString);
        }


        [HttpGet]
        public List<RefContactTypes> Get()
        {
          
            return _RefContactTypesService.GetRefContactTypes();
        }
         
        [HttpPost]

        public RefContactTypes Add(RefContactTypes refcontacttypes)
        {
            bool alreadyExist = _RefContactTypesService.IsAlreadyRegistered(refcontacttypes.ContactCode);
            if (alreadyExist)
                return null;
            _RefContactTypesService.Add(refcontacttypes);
            return refcontacttypes;
        }
        [HttpPut]

        public RefContactTypes Update(RefContactTypes refcontacttypes)
        {
            _RefContactTypesService.Update(refcontacttypes);
            return refcontacttypes;
        }

        [HttpDelete]
        public RefContactTypes Delete(RefContactTypes refContactTypes)
        {
            _RefContactTypesService.Delete(refContactTypes);
            return refContactTypes;  
        }
        
    }
}
