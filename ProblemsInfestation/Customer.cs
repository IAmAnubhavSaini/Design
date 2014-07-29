using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsInfestation
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

        //Violating LSP
        public string CustomerPrivilege { get; set; }

        public virtual string GetCustomerPrivilege()
        {
            if(CustomerPrivilege == null){
                throw new NullReferenceException();
            }
            return CustomerPrivilege;
        }
    }

    // Violating LSP 
    // refer Customer
    // refer Program
    public class PrivilegedCustomer : Customer
    {
        public PrivilegedCustomer()
        {
            CustomerPrivilege = "privy";
            someRandomThing = 1;
        }
        int someRandomThing;
        public override string GetCustomerPrivilege()
        {
            if(CustomerPrivilege == null){
                throw new NullReferenceException();
            }
            // This is the violation of the LSP;
            if(someRandomThing < 10){
                throw new ArgumentOutOfRangeException();
            }
            return CustomerPrivilege;
        }
    }
}
