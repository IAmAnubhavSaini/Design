using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsInfestation
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Customer Customer { get; set; }
        // Following arbitrary limit of 64 on products an order can contain is
        // violating Zero-One-Infinity rule
        public Product[] Products = new Product[64];
    }
}
