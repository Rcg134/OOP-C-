using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composition.Customers;
using Composition.GeneralFuntions;

namespace Composition
{


    class Program
    {
        static void Main(string[] args)
        {
            var dialog = new Dialog(new ImportFile() , 
                                    new ExportFile());


            dialog.LocalExportFile();
            dialog.LocalImportFile();
            

        }
    }
}
