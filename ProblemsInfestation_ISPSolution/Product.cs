using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsInfestation_ISPSolution
{

    interface ISellableProduct
    {
        bool ProductSold { get; set; }
        decimal ProductPrice { get; set; }
    }

    interface IExpireableProduct
    {
        DateTime ProductExpiryDate { get; set; }
    }

    public class Product : ISellableProduct, IExpireableProduct
    {
        //Should have a factory instead of constructor only creation
        public Product()
        {
            ProductId = new Guid();
        }
        public Guid ProductId { get; private set; }

        public string ProductName { get; set; }

        // Interface implementations
        public bool ProductSold { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime ProductExpiryDate { get; set; }
    }
}
