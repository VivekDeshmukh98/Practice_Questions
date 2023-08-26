using Joining_and_Combining2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joining_and_Combining2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                 new Customer { CustomerID = 1, Name = "Alice" },
            new Customer { CustomerID = 2, Name = "Bob" }
            };

            List<Order> orders = new List<Order>
            {
                 new Order { OrderID = 1, CustomerID = 1, Product = "Laptop" },
            new Order { OrderID = 2, CustomerID = 2, Product = "Phone" },
            new Order { OrderID = 3, CustomerID = 1, Product = "Tablet" }
        };


            var orderswithCustomers = orders.Join(customers, order => order.CustomerID, customer => customer.CustomerID, (order, customer) => new
            {
                order.OrderID,
                customer.Name,
                order.Product
            });

            foreach (var item in orderswithCustomers)
            {
                Console.WriteLine($"Order ID: {item.OrderID }, Customer : { item.Name}, Prodcut: {item.Product}");
            }

            Console.ReadKey();
        }
    }
}
