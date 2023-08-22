using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Program 
    {
        static void Main(string[] args)
        {
            var _infinion = new Infinio();
            var _values = new int[] { 1, 2, 3 };
            var _result = _infinion.Calculate(_values);
            Console.WriteLine(_result);
          
        }
    }
}
