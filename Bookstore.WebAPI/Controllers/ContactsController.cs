using Bookstore.Data.Entitites;
using Bookstore.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private static ContactsService _ContactsService { get; set; } = new ContactsService();

        [HttpGet]
        public List<Contacts> Get()
        {
            return _ContactsService.GetContacts();
        }

        // IsAlreadyExist is  not working
        [HttpPost]
        public ActionResult<Contacts> Add(Contacts contacts)
        {
            bool alreadyexist = _ContactsService.IsAlreadyExist(contacts.CondtactID, contacts.ContactFirstName,contacts.ContactLastName);
            if (!alreadyexist)
            {
                return _ContactsService.Add(contacts);
                
            }
            return BadRequest("User Already Exist");
        }

        [HttpPut]
        public Contacts Update(Contacts contacts)
        {
          _ContactsService.Update(contacts);
            return contacts;
        }

        [HttpDelete]
        public Contacts Delete(Contacts contacts)
        {
            _ContactsService.Delete(contacts);
            return contacts;
        }
    }


}
