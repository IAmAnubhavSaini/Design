using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProblemsInfestation_SRPSolution
{
    public class BusinessActions
    {
        public static bool SellProduct(Product product, Order order, Customer customer)
        {
            
            if (product != null)
            {
                if (product.ProductSold == true) return false;
                if (order.Customer.CustomerId != customer.CustomerId) return false;

                // this automatically becomes the else part
                product.ProductSold = true;
                order.Kart.Add(product);
                
                // Okay, you want to rip my face off, saying where is customer and why 
                // the dependency is upon Product class directly, well, I solved SRP only here. :)
                
            }
            return true;
        }
    }
}
