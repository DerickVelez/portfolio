using GamingStore.Data.Entities;
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
        public bool IsAlreadyRegistered(int productTypeCode)
        {
            var producttypes = productTypesList.Where(x => x.ProductTyopeCode == productTypeCode).FirstOrDefault();
            return producttypes != null;
        }
        public List<ProductTypes> GetProductTypes()
        {
            return productTypesList;
        }

        public void Add(ProductTypes productstype
            )
        {
            productTypesList.Add(productstype);
        }

        public List<ProductTypes> Delete(ProductTypes productstype)
        {
            productTypesList = productTypesList.Where(a => a.ProductTyopeCode != productstype.ProductTyopeCode).ToList();
            return productTypesList;
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
