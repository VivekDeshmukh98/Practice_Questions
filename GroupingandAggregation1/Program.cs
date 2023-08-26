using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupingandAggregation1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Group a list of products by their categories using LINQ.

            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Category = "Electronics" },
            new Product { Name = "Shirt", Category = "Clothing" },
            new Product { Name = "TV", Category = "Electronics" },
            new Product { Name = "Jeans", Category = "Clothing" },
            new Product { Name = "Phone", Category = "Electronics" }
            };


            var groupedProducts = products.GroupBy(p => p.Category);


            foreach (var group in groupedProducts)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var product in group)
                {
                    Console.WriteLine($"- {product.Name}");
                }
            }


            Console.ReadKey();
        }


    }
}
