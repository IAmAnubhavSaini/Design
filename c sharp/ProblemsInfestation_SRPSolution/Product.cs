using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolution_SRP
{
    public class Product
    {
        //Should have a factory instead of constructor only creation
        public Product()
        {
            ProductId = new Guid();
        }
        public Guid ProductId { get; private set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public DateTime ProductExpiryDate { get; set; }

        public bool ProductSold { get; set; }

        // Product selling is done via BusinessActions
        // Selling itself is not the Product's responsibility
        // thus SRP problem has been removed from here
        // refer ProblemsInfestation.Product
    }


}
