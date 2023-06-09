﻿using GameStore.Service;
using GamingStore.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private static ProductTypesService _producttypeserviceList;

        public ProductTypeController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DerickServer");
            _producttypeserviceList = new ProductTypesService(connectionString);
        }

        [HttpGet]
        public List<ProductTypes> Get()
        {
            return _producttypeserviceList.GetProductTypes();
        }

        [HttpPost]
        public ProductTypes Add(ProductTypes producttypes)
            {
            bool alreadyexist = _producttypeserviceList.IsAlreadyRegistered(producttypes.ProductTypeCode);
            if (alreadyexist)
                return null;

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
   

