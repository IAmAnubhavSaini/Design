using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsInfestation
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

        //This function here violates SRP
        public void SellProduct()
        {
            // Any code here would be violating SRP
        }
    }
}
