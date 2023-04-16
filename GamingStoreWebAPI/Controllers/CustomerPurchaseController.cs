using GameStore.Service;
using GamingStore.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerPurchaseController : ControllerBase
    {
        private static CustomerPurchaseService _customerpurchaseService;

        public CustomerPurchaseController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DerickServer");
            _customerpurchaseService = new CustomerPurchaseService(connectionString);
        }

        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

        public CustomerPurchaseController(
            FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider
                ?? throw new System.ArgumentNullException(nameof(fileExtensionContentTypeProvider));
        }       

  


        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileID)
        {
            var pathToFile = "Jan Derick Velez resume.pdf";

            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }
            if (!_fileExtensionContentTypeProvider.TryGetContentType(pathToFile, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes, "text/plain", Path.GetFileName(pathToFile));
        }

        //[HttpGet]
        //public List<CustomerPurchase> Get()
        //{
        //    return _customerpurchaseService.GetCustomerPurchase();

        //}
        [HttpPost]
        public CustomerPurchase Add(CustomerPurchase customerpurchase)
        {
            bool alreadyexist = _customerpurchaseService.IsAlreadyRegistered(customerpurchase.PurchaseID);
            if (alreadyexist)
                return null;

            _customerpurchaseService.Add(customerpurchase);
            return customerpurchase;
        }
        [HttpPut]
        public CustomerPurchase Update(CustomerPurchase customerpurchase)
        {
            _customerpurchaseService.Update(customerpurchase);
            return customerpurchase;
        }
        [HttpDelete]

        public CustomerPurchase Delete(CustomerPurchase customerpurchase)
        {
            _customerpurchaseService.Delete(customerpurchase);
            return customerpurchase;
        }

    }
}
