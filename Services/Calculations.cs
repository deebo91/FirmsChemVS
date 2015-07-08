using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using FirmsChemVS.Repositories;
using FirmsChemVS.Services;

namespace FirmsChemVS.Services
{
    public class Calculations
    {
        IsotopeService isotopeService = IsotopeService.Instance;
        private static Calculations instance;
        private Dictionary<string, int> currentRowElements = null;

        public static Calculations Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculations();
                }
                return instance;
            }
        }

        public Dictionary<string, int> CurrentRowElements
        {
            get
            {
                return this.currentRowElements;
            }
            set
            {
                this.currentRowElements = value;
            }
        }
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
            DataTable combinationTable = new DataTable();


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
            combinationTable.Columns.AddRange(new DataColumn[]{new DataColumn("combination"), new DataColumn("mass")});
            foreach (Isotope element in listOfIsotopes)
            {
                ArrayList elementGroup = expandedCompound[element.atomSymbol];
                int temp = (int)elementGroup[elementGroup.Count - 1];
                elementGroup.RemoveAt(elementGroup.Count - 1);
                elementGroup.Add(element.isotopeNumber);
                int newIsotopeMass = calculateIsotopicMass(expandedCompound);
                mSets.Add("M + " + (newIsotopeMass - molecularBaseMass));
                combinationTable.Rows.Add(new object[] { outputIsotopeFormula(expandedCompound), newIsotopeMass + "+" });
                elementGroup.RemoveAt(elementGroup.Count - 1);
                elementGroup.Add(temp);
            }

            DataReporter.exportDataSetToExcelFile(combinationTable);

            
            

            return new List<string>();
        }

        string outputIsotopeFormula(Dictionary<string, ArrayList> expandedCompound)
        {
            string finalOutput = "";
            foreach (var elementGroup in expandedCompound)
            {
                string currentCompound = elementGroup.Key;
                foreach (int item in elementGroup.Value)
                {
                    finalOutput += item + currentCompound;
                }
            }
            return finalOutput;
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

        public double calculateAlphaForRow(long totalAbundances, long abundance)
        {
            return Math.Round(((double)abundance / (double)totalAbundances),5);
        }

        public void isotopeCombinations(int[] isotopes, int[] counts, int startIndex, int totalAmount,  List<Dictionary<int,int>> outputResults)
        {
            Dictionary<string, int> totalAllowableIsotopes = new Dictionary<string, int>();
            if (startIndex >= isotopes.Length)
            {
                string[] isotopeChars = isotopeService.getAllIsotopesInList(isotopes);
                for (int index = 0; index < isotopeChars.Length; index++)
                {
                    int retrievedValue;
                    
                    if (totalAllowableIsotopes.TryGetValue(isotopeChars[index], out retrievedValue))
                    {
                        totalAllowableIsotopes[isotopeChars[index]] = retrievedValue + counts[index];
                    }
                    else
                    {
                        totalAllowableIsotopes.Add(isotopeChars[index], counts[index]);
                    }
                }

                var dict3 = CurrentRowElements.Where(entry => totalAllowableIsotopes[entry.Key] != entry.Value)
                 .ToDictionary(entry => entry.Key, entry => entry.Value) as Dictionary<string, int>;

                if (dict3.Count == 0)
                {
                    Dictionary<int, int> results = new Dictionary<int, int>();
                    for (int index = 0; index < isotopes.Length; index++)
                    {
                        results.Add(isotopes[index], counts[index]);
                        
                        Console.Write(" ({0:N}:{1:N}) ", isotopes[index], counts[index]);
                    }
                    outputResults.Add(results);
                }
                Console.WriteLine(" ");
                return;
            }

            if (startIndex == isotopes.Length - 1)
            {
                if (totalAmount % isotopes[startIndex] == 0)
                {
                    counts[startIndex] = totalAmount / isotopes[startIndex];
                    isotopeCombinations(isotopes, counts, startIndex + 1, 0, outputResults);
                }
            }
            else
            {
                for (int i = 0; i <= totalAmount / isotopes[startIndex]; i++)
                {
                    counts[startIndex] = i;
                    isotopeCombinations(isotopes, counts, startIndex + 1, totalAmount - isotopes[startIndex] * i,outputResults);
                }
            }
        }

        public double calculateIsotopeDividend(List<Dictionary<int,int>> partOfFraction, int[] isotopeNumbers)
        {
            var isotopeWithAbundances = isotopeService.getAllAbundancesByisotopeNumber(isotopeNumbers);
            double total = 0.0;
            foreach (Dictionary<int, int> calcItem in partOfFraction)
            {
                double acc = 1;
                foreach (KeyValuePair<int, int> element in calcItem)
                {
                    acc *= Math.Pow(isotopeWithAbundances[element.Key] / 100, element.Value);
                }
                total += acc;
                acc = 1;
            }

            return total;
        }
    }
}
