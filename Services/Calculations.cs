using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace FirmsChemVS.Services
{
    class Calculations
    {
        
        public double CalculateMolecularWeight(DataTable elements)
        {
            double molecularWeight = 0;
            using (FirmsChemVS.Repositories.FirmsChemDBEntities db = new Repositories.FirmsChemDBEntities())
            {
                foreach(DataRow row in elements.Rows){
                    string symbol = row[0] as string;
                    if (Convert.ToInt32(row[1]) > 0) { 
                    var query = ((from isotope in db.Isotopes
                                 where isotope.atomSymbol == symbol
                                 select isotope).OrderByDescending(i => i.abundance)).First();
                    molecularWeight += (double)query.atomMass * Convert.ToInt32(row[1]);
                    }
                }
                
            }
            return molecularWeight;
        }

        public string CalculateMolecularFormula(DataTable elements)
        {
            String formula = "";
            foreach (DataRow entry in elements.Rows)
            {
                if (Convert.ToInt32(entry[1]) > 0)
                {
                    if (Convert.ToInt32(entry[1]) == 1)
                    {
                        formula += entry[0];
                    }
                    else
                    {
                        formula += (string)entry[0] + (string)entry[1];
                    }
                }
            }
            return formula;
        }
    }
}
