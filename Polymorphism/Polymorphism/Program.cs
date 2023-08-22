using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism.Customers;
using Polymorphism.Model;


namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var _customers = new List<Customer>();


            var dialogmodel = new DialogModel();
            dialogmodel.message = "Import";
            _customers.Add(new Dialog(dialogmodel));


            var _getCustomer = new GetCustomer();
            _getCustomer.GeneratePayment(_customers);
            _getCustomer.GenerateImport(_customers);


        }
    }
}
