using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedQueriesAndSubQueries.Models
{
    class Product
    {
        public int ProductID { set; get; }
        public string Name { get; set; }
        public decimal Price { set; get; }
        public int StockQuantity { set; get; }
    }
}
