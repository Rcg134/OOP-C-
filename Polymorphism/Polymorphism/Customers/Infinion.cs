using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Customers
{
    public class Infinion : Customer
    {
        public override void payMentTerms()
        {
            Console.WriteLine("90 days");
        }
    }
}
