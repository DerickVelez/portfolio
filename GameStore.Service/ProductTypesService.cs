using GamingStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Service
{
    public class ProductTypesService
    {
        private List<ProductTypes> productTypesList = new List<ProductTypes>
        {
            new ProductTypes
            {
                ProductTyopeCode = 464,
                ProducTypeDescription = "dfjkj",

            }
        };
         public List<ProductTypes> Get()
        {
            return productTypesList;
        }

        public void Add(ProductTypes productstypes)
        {
            productTypesList.Add(productstypes);
        }

        public void Delete(ProductTypes productstypes)
        {
            productTypesList.Remove(productstypes);
        }

        public void Update(ProductTypes productstypes)
        {
            var selectedCustomerPurchase = productTypesList.Where(a => a.ProductTyopeCode == productstypes.ProductTyopeCode).FirstOrDefault();
        }

        public ProductTypes? FindById(int productcode)
        {
            return productTypesList.Where(a => a.ProductTyopeCode == productcode).FirstOrDefault();
        }
    }
}
