using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolution_Factory
{
    public class Customer
    {
        // Again Get a factory dude.
        public Customer()
        {
            CustomerId = new Guid();
        }
        public Guid CustomerId { get; private set; }

        public string CustomerName { get; set; }
    }
}
