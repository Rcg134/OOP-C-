using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism.Model;

namespace Polymorphism.Customers
{
    public class Dialog : Customer
    {
        private DialogModel _dialogmodel;

        public Dialog()
        {
        }


        public Dialog(DialogModel dialogmodel)
        {
            _dialogmodel = dialogmodel;
        }

        public override void payMentTerms()
        {
            Console.WriteLine("60 days");
        }

        public override void Import()
        {
            Console.WriteLine(_dialogmodel.message);
        }
    }
}
