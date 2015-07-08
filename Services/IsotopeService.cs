using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmsChemVS.Services
{
    public class IsotopeService
    {
        private static IsotopeService instance;

        public static IsotopeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new IsotopeService();
                }
                return instance;
            }
        }
        public List<Repositories.Isotope> getAllIsotopesForAtom(string symbol){
            List<Repositories.Isotope> listOfIsotopes;
            using(FirmsChemVS.Repositories.FirmsChemDBEntities db = new Repositories.FirmsChemDBEntities()){
                var query = ((from isotope in db.Isotopes
                                 where isotope.atomSymbol == symbol
                                 select isotope).OrderByDescending(i => i.abundance)).ToList();
                    listOfIsotopes = query;
            }
            return listOfIsotopes;
        }

        public string[] getAllIsotopesInList(int[] isotopes)
        {
            string[] listOfIsotopes;
            using (FirmsChemVS.Repositories.FirmsChemDBEntities db = new Repositories.FirmsChemDBEntities())
            {
                var query = (from isotope in db.Isotopes
                            where isotopes.Contains(isotope.isotopeNumber ?? 0)
                            orderby isotope.isotopeNumber descending
                            select isotope.atomSymbol).ToArray();
                listOfIsotopes = query;
            }
            return listOfIsotopes;
        }

        public Dictionary<int, double> getAllAbundancesByisotopeNumber(int[] isotopeNumbers)
        {
            Dictionary<int, double> isotopeNumbersWithAbundance;
            using (FirmsChemVS.Repositories.FirmsChemDBEntities db = new Repositories.FirmsChemDBEntities())
            {
                isotopeNumbersWithAbundance = (from isotope in db.Isotopes
                                               where isotopeNumbers.Contains(isotope.isotopeNumber ?? 0)
                                               select new { isotope.isotopeNumber, isotope.abundance }).ToDictionary(element => (element.isotopeNumber ?? 0), element => (element.abundance ?? 0));
            }
            return isotopeNumbersWithAbundance;
        }

        public int[] getAllIsotopesInIsotopeSymbols(string[] atomSymbol)
        {
            int[] isotopes;
            using(FirmsChemVS.Repositories.FirmsChemDBEntities db = new Repositories.FirmsChemDBEntities())
            {
                isotopes = (from isotope in db.Isotopes
                            where atomSymbol.Contains(isotope.atomSymbol)
                            orderby isotope.isotopeNumber descending
                            select isotope.isotopeNumber ?? 0).ToArray();
            }
            return isotopes;
        }
    }
}
