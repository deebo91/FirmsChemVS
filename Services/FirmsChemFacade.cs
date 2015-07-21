using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FirmsChemVS.Services
{
    public class FirmsChemFacade
    {
        private static FirmsChemFacade instance;
        private DataReporter dataReporter;
        private DataWriter dataWriter;
        private DataInitializer initializer;
        private Calculations calculations;
        private IsotopeService isotopeService;
        

        private FirmsChemFacade()
        {
            dataWriter = new DataWriter();
            initializer = new DataInitializer();
            calculations = new Calculations();
            isotopeService = new IsotopeService();
        }

        public static FirmsChemFacade Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new FirmsChemFacade();
                }
                return instance;
            }
        }
        

        public void InitGrids(Object elementGrid)
        {
            initializer.InitializeElementGrid(elementGrid as DataGridView);
        }

        public double CalculateMolecularWeight(DataGridView elementGrid)
        {
            DataTable dt = DataReporter.convertDatagridToDatatable(elementGrid);
            return calculations.CalculateMolecularWeight(dt);
        }

        public string CalculateMolecularFormula(DataGridView elementGrid)
        {
            DataTable dt = DataReporter.convertDatagridToDatatable(elementGrid);
            return calculations.CalculateMolecularFormula(dt);
        }

        public bool exportDataSetToExcelFile(DataGridView grid)
        {
            dataReporter = new DataReporter(grid);
            return DataReporter.exportDataSetToExcelFile(dataReporter.DataForGrid2);
        }

        public List<string> CalculateIsotopeCombinations(DataGridView grid)
        {
            DataTable dt = DataReporter.convertDatagridToDatatable(grid);
            return calculations.possibleIsotopeCombinations(dt);
        }

        public void abundanceForRow(DataGridView grid)
        {
            ArrayList Abundances = DataGridViewHelper.ColumnToList(grid, "abundances");
            double totalAbundance = 0;
            foreach(String abundance in Abundances){
               totalAbundance += Convert.ToDouble(abundance);
            }
            foreach (DataGridViewRow row in grid.Rows)
            {
                if(row.Cells["abundances"].Value != null){
                    row.Cells["alphas"].Value = calculations.calculateAlphaForRow(totalAbundance, Convert.ToDouble(row.Cells["abundances"].Value));
                }
            }
        }

        
    
    
    
    
    
    }
}
