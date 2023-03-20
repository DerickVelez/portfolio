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
         public List<ProductTypes> GetProductTypes()
        {
            return productTypesList;
        }

        public void Add(ProductTypes productstype
            )
        {
            productTypesList.Add(productstype);
        }

        public void Delete(ProductTypes productstype)
        {
            productTypesList.Remove(productstype);
        }

        public void Update(ProductTypes productstype)
        {
            var selectedCustomerPurchase = productTypesList.Where(
                a => a.ProductTyopeCode == productstype.ProductTyopeCode).FirstOrDefault();
            productTypesList.Remove(selectedCustomerPurchase);
            productTypesList.Add(productstype);
        }

        public ProductTypes? FindById(int productcode)
        {
            return productTypesList.Where(a => a.ProductTyopeCode == productcode).FirstOrDefault();
        }
    }
}
