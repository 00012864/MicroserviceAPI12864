using _12864MicroserviceApplication.DbContexts;
using _12864MicroserviceApplication.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12864MicroserviceApplication.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Getting an individual product according to the ID
        public Product GetProductById(int productId)
        {
            var prod = _dbContext.Products.Find(productId);
            _dbContext.Entry(prod).Reference(pr => pr.ProductCategory).Load();
            return prod;
        }

        // Getting list of all the products
        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.Include(pr => pr.ProductCategory).ToList();
        }

        // Adding a product
        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        // To edit the products
        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State =
           Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

        // Finding the product with the corresponding ID and deleting it
        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            _dbContext.Products.Remove(product);
            Save();
        }

    }
}
