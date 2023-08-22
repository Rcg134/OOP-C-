using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Polymorphism
{
    public class Customer
    {

        //method overriding
        public virtual void payMentTerms()
        {
            Console.WriteLine("Default Payment");
        }
        public virtual void Import()
        {
        }

    }

    //public abstract class Customer
    //{
    //    //Use abstract modifier if you are not sure for implementation
    //    public abstract void payMentTerms();
    //}






}
