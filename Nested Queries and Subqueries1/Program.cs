using Nested_Queries_and_Subqueries1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Queries_and_Subqueries1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerID = 1, Name = "Alice" },
            new Customer { CustomerID = 2, Name = "Bob" },
            new Customer { CustomerID = 3, Name = "Charlie" }
        };

            List<Order> orders = new List<Order>
        {
            new Order { OrderID = 1, CustomerID = 1 },
            new Order { OrderID = 2, CustomerID = 2 },
            new Order { OrderID = 3, CustomerID = 1 }
        };


            var customersWithOrders = customers.Where(customer => orders.Any(order => order.CustomerID == customer.CustomerID));

            foreach (var item in customersWithOrders)
            {
                Console.WriteLine($"Customer with Orders: {item.Name}");
            }
        }
    }
}
