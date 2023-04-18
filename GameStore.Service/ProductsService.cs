using GamingStore.Data.Entities;
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

        private string connectionString;

        public ProductsService(string connectionString)
        {
        this.connectionString = connectionString;
        }

        public bool IsAlreadyRegistered(int productID)
        {
            var products = productsList.Where(x => x.ProductID == productID).FirstOrDefault();
            return products != null;
        }
        public List<Products> GetProducts()
        {
            return productsList;
        }

        public void Add(Products product)
        {
            productsList.Add(product);
        }

        public List<Products> Delete(Products product)
        {
            productsList = productsList.Where(a => a.ProductID != product.ProductID).ToList();
            return productsList;
        }

        public void Update(Products product)
        {
            var selectedCustomerPurchase = productsList.Where(
                a => a.ProductID == product.ProductID).FirstOrDefault();
            productsList.Remove(selectedCustomerPurchase);
            productsList.Add(product);
        }

        public Products? FindById(int productId)
        {
            return productsList.Where(a => a.ProductID == productId).FirstOrDefault();
        }
    }
}
