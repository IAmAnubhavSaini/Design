using System;

namespace ProblemsInfestation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            try
            {
                c.GetCustomerPrivilege();
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
            }

            Customer pc = new PrivilegedCustomer();
            try
            {
                Console.WriteLine(pc.GetCustomerPrivilege());
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
            }
        }


    }
}
