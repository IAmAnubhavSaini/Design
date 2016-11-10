using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolution_ZOI
{
    
    public class Order
    {
        public Guid OrderId { get; set; }
        public Customer Customer { get; set; }

        // How we kill the ZOI problem: refer ProblemsInfestation.Order
        public List<Product> Products = new List<Product>(); 
    }

    
    /* for sake of not getting errors while accessing Customer or Product*/

    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
    }

    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
