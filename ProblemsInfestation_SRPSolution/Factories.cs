using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolution_SRP
{
    public class Factories
    {
        public Product GetDefaultProduct()
        {
            return new Product();
        }

        public Product GetProduct(string productName)
        {
            var p = new Product();
            if (!string.IsNullOrEmpty(productName))
            {
                p.ProductName = productName;
            }
            return p;
        }

        public Customer GetDefaultCustomer()
        {
            return new Customer();
        }

        public Customer GetCustomer(string customerName)
        {
            var c = new Customer();
            if (!string.IsNullOrEmpty(customerName))
            {
                c.CustomerName = customerName;
            }
            return c;
        }
    }
}
