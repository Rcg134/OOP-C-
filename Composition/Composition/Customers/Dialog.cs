using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composition.GeneralFuntions;

namespace Composition.Customers
{
    public class Dialog
    {

        private readonly ImportFile _importFile;
        private readonly ExportFile _exportFile;

        public Dialog(ImportFile importfile , ExportFile exportfile)
        {
            _importFile = importfile;
            _exportFile = exportfile;
        }


        public void LocalImportFile()
        {
            _importFile.Import("Importing File");
        }

        public void LocalExportFile()
        {
            _exportFile.Export("Exporting File");
        }
    }
}
