using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmsChemVS.Services
{
    class DataGridViewHelper
    {

        public static ArrayList ColumnToList(DataGridView grid, String ColumnName)
        {
            ArrayList returnList = new ArrayList();
            foreach (DataGridViewRow row in grid.Rows)
            {
                
                    if(row.Cells[ColumnName].Value != null){
                        returnList.Add(row.Cells[ColumnName].Value);
                    }

            }

            return returnList;
        }

        public static Dictionary<string, int> elementDataGridToDictionary(DataGridView elementGrid)
        {
            var elementMap = new Dictionary<string, int>();
            foreach (DataGridViewRow row in elementGrid.Rows)
            {
                int numberOfAtoms = Convert.ToInt32(row.Cells["numberOfAtoms"].Value);

                if (numberOfAtoms != 0)
                {
                    elementMap.Add(row.Cells[0].Value as String, Convert.ToInt32(row.Cells[1].Value));
                }

            }
            return elementMap;
        }
    }
}
