using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12864MicroserviceApplication.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
        
        public Category ProductCategory { get; set; }

    }
}
