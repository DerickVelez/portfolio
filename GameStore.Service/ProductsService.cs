using GamingStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Service
{
    public class ProductsService
    {
        private List<Products> productsList = new List<Products>
        {
            new Products
            {
                ProductID = 54,
                ProductDescription = "dfhd",
                ProductName = "bengbeng",
                ProductPrice = 10000,
                ProductTypeCode = 45,
            }
        };
        public List<Products> Get()
        {
            return productsList;
        }

        public void Add(Products products)
        {
            productsList.Add(products);
        }

        public void Delete(Products products)
        {
            productsList.Remove(products);
        }

        public void Update(Products products)
        {
            var selectedCustomerPurchase = productsList.Where(a => a.ProductID == products.ProductID).FirstOrDefault();
        }

        public Products? FindById(int productId)
        {
            return productsList.Where(a => a.ProductID == productId).FirstOrDefault();
        }
    }
}
