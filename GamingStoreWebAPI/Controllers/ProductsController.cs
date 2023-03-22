using GameStore.Service;
using GamingStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static ProductsService _productsService { get; set; } = new ProductsService();

        [HttpGet]
        public List<Products> Get()
        {
           return _productsService.GetProducts();
          
        }
        [HttpPost]
        public Products Add(Products products)
        {
            bool alreadyexist = _productsService.IsAlreadyRegistered(products.ProductID);
            if (alreadyexist)
                return null;

            _productsService.Add(products);
            return products;
        }
        [HttpPut]
        public Products Update(Products products)
        {
            _productsService.Update(products);
            return products;
        }
        [HttpDelete]
        
        public Products Delete(Products product)
        {
            _productsService.Delete(product);
            return product;
        }

    }
}
