using NestedQueriesAndSubQueries3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedQueriesAndSubQueries3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finding Customers with Orders Exceeding Total Amount Using LINQ Query:
            List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerID = 1, Name = "Alice" },
            new Customer { CustomerID = 2, Name = "Bob" },
            new Customer { CustomerID = 3, Name = "Charlie" }
        };

            List<Order> orders = new List<Order>
        {
            new Order { OrderID = 1, CustomerID = 1, TotalAmount = 1200 },
            new Order { OrderID = 2, CustomerID = 2, TotalAmount = 800 },
            new Order { OrderID = 3, CustomerID = 1, TotalAmount = 300 }
        };
            decimal minTotalAmoint = 1000;

            var customerWithHighTotalAmount = from customer in customers
                                              join order in orders
                                              on customer.CustomerID equals order.CustomerID
                                              where order.TotalAmount > minTotalAmoint
                                              select customer;

            foreach (var item in customerWithHighTotalAmount)
            {
                Console.WriteLine($"Customer with High Total Amount: {item.Name}");
            }

        }
    }
}
