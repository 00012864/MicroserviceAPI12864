using _12864MicroserviceApplication.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12864MicroserviceApplication.DbContexts
{
    public class ProductContext : DbContext 
    {
        // Constructors
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        // Represents products table in database
        public DbSet<Product> Products { get; set; }


        // Represents categories table in database
        public DbSet<Category> Categories { get; set; }

    }

}
