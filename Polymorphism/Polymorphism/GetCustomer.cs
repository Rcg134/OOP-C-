using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class GetCustomer
    {
        public void GeneratePayment(List<Customer> customers)
        {
           foreach(var customer in customers)
            {
                customer.payMentTerms();
            }
        }

        public void GenerateImport(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                customer.Import();
            }
        }

    }
}
