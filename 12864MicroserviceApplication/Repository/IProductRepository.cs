using _12864MicroserviceApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12864MicroserviceApplication.Repository
{
    public interface IProductRepository
    {
       public void InsertProduct(Product product);

       public void UpdateProduct(Product product);

       public void DeleteProduct(int productId);

       public Product GetProductById(int id);

       public IEnumerable<Product> GetProducts();

    }
}
