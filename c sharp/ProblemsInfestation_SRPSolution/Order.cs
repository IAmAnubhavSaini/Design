using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProblemsSolution_SRP
{
    public class Order
    {
        public Guid OrderId { get; set; }

        //Okay Kart here breaks extensibility. It should have been some interface
        public List<Product> Kart { get; set; }

        // again depending upon Concrete class. 
        public Customer Customer { get; set; }
    }
}
