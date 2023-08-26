using NestedQueriesAndSubQueries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedQueriesAndSubQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retrieving Products in Stock with Certain Price Using Subquery:

            List<Product> products = new List<Product>
        {
            new Product { ProductID = 1, Name = "Laptop", Price = 800, StockQuantity = 10 },
            new Product { ProductID = 2, Name = "Phone", Price = 500, StockQuantity = 5 },
            new Product { ProductID = 3, Name = "Tablet", Price = 300, StockQuantity = 0 }
        };

            decimal maxPrice = 600;

            var productsInStockwithPrice = products.Where(prod => prod.StockQuantity > 0 && prod.Price <= maxPrice);


            foreach (var item in productsInStockwithPrice)
            {
                Console.WriteLine($"Product: {item.Name}, Price: {item.Price:C} ");
            }
            Console.ReadKey();
        }
    }
}
