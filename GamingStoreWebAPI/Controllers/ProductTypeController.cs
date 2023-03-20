using GameStore.Service;
using GamingStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private static ProductTypesService _producttypeserviceList { get; set; } = new ProductTypesService();

        [HttpGet]
        public List<ProductTypes> Get()
        {
            return _producttypeserviceList.GetProductTypes();
        }

        [HttpPost]
        public ProductTypes Add(ProductTypes producttypes)
            {
            _producttypeserviceList.Add(producttypes);   
            return producttypes;
            }
        [HttpPut]
        public ProductTypes Update(ProductTypes producttypes)
        {
            _producttypeserviceList.Update(producttypes);
            return producttypes;
        }
        [HttpDelete]
        public ProductTypes Delete(ProductTypes producttypes)
        {
            _producttypeserviceList.Delete(producttypes);
            return producttypes;
        }
    }
}
   

