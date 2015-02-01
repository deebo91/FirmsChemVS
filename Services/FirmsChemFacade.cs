using System;
using System.Collections.Generic;
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
        

        private FirmsChemFacade()
        {
            dataWriter = new DataWriter();
            initializer = new DataInitializer();
            calculations = new Calculations();
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
            return dataReporter.exportDataSetToExcelFile();
        }
    
    
    
    
    
    }
}
