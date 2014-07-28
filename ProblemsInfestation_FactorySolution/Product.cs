using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsInfestation_FactorySolution
{
    public class Product
    {
        //Should have a factory instead of constructor.
        public Product()
        {
            ProductId = new Guid();
        }
        public Guid ProductId { get; private set; }

        public string ProductName { get; set; }
    }
}
