using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using FirmsChemVS.Repositories;

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

        public int fractionCalculation(int numberOfMolecules, double[] fractionPercent)
        {
            int result = numberOfMolecules;
            for (int index = 0; index < fractionPercent.Length; index++ )
            {
                //result *= fractionPercent[index];
            }

            return result;
        }

        public List<string> possibleIsotopeCombinations(DataTable dt)
        {
            Dictionary<string, ArrayList> expandedCompound = new Dictionary<string, ArrayList>();


            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row[1] as string) > 0)
                {

                
               int isotopeMass = 0;
               ArrayList isotopeNumList = new ArrayList();
                using (FirmsChemVS.Repositories.FirmsChemDBEntities db = new Repositories.FirmsChemDBEntities())
                {
                    var symbol = row[0] as string;
                    var query = ((from isotope in db.Isotopes
                                 where isotope.atomSymbol == symbol
                                 select isotope).OrderByDescending(i => i.abundance)).First();
                    isotopeMass = (int)query.isotopeNumber;
                 }
                
                for (int index = 0; index < Convert.ToInt32(row[1]); index++)
                {
                    isotopeNumList.Add(isotopeMass);
                }
                expandedCompound.Add(row[0].ToString(), isotopeNumList);
                }
            }

            int molecularBaseMass = 0;              //base molecular mass
            foreach (var pair in expandedCompound)
            {
                foreach (int item in pair.Value)
                {
                    molecularBaseMass += item;
                }
            }

            List<Isotope> listOfIsotopes;
            HashSet<string> mSets = new HashSet<string>();

            //retrieve list of all isotopes for each element.
            using (FirmsChemVS.Repositories.FirmsChemDBEntities db = new Repositories.FirmsChemDBEntities())
            {
                var query = (from isotope in db.Isotopes
                              where expandedCompound.Keys.Contains(isotope.atomSymbol)
                              select isotope);
                listOfIsotopes = query.ToList();
                
            }
            foreach (Isotope element in listOfIsotopes)
            {
                ArrayList elementGroup = expandedCompound[element.atomSymbol];
                int temp = (int)elementGroup[elementGroup.Count - 1];
                elementGroup.RemoveAt(elementGroup.Count - 1);
                elementGroup.Add(element.isotopeNumber);
                mSets.Add("M + " + (calculateIsotopicMass(expandedCompound) - molecularBaseMass));
                elementGroup.RemoveAt(elementGroup.Count - 1);
                elementGroup.Add(temp);
            }
           

            
            

            return new List<string>();
        }

        int calculateIsotopicMass(Dictionary<string, ArrayList> expandedCompound)
        {
            int isotopicMass = 0;
            foreach (KeyValuePair<string, ArrayList> entry in expandedCompound)
            {
                foreach (int item in entry.Value)
                {
                    isotopicMass += item;
                }
            }
            return isotopicMass;
        }
    }
}
