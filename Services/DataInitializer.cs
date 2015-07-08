using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmsChemVS.Services
{
    class DataInitializer
    {
        private string[] Elements;

        public DataInitializer()
        {
            Elements = new string[] {"C","H","Br","Cl","F","I","N","S","P","Si","O" };
            
            
        }
        public void InitializeElementGrid(DataGridView elementGrid)
        {
            foreach (string element in Elements)
            {
                elementGrid.Rows.Add(new object[] { element, "0" });
            }
        }

        
    }
}
