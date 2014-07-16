// Importing system library
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmsChemVS
{
    public partial class Form1 : Form
    {
        // Declearing all the variables as strings, doubles or integers
        String IsCompoundName;                  // compound name
        String MolecularFormula;                // compound molecular formula
        double MolecularWeight;                 // compound molecular weight including decimals
        // Integer values for the number of each atom present in the compound
        int Ccarbon;
        int Hhydrogen;
        int Nnitrogen;
        int Ooxygen;
        int Fflourine;
        int Cchlorine;
        int Bbromine;
        int Iiodine;
        int Ssulfur;
        int Pphosphorus;
        int Ssilicon;
        int FragmentMS;
        int IsotopewithavailableMSdata;
        double CompoundBaseMass;  // the mass of a fragment including decimal
        Dictionary<String, String[]> elementHash = new Dictionary<string, string[]>(); // Variable that can hold a key and a value for the element and
        // the number of atoms
        Dictionary<String, int> elementValues; // variable that can hold a key and a value for the element and its isotopes

        public Form1()
        {
            InitializeComponent();
            elementValues = new Dictionary<String, int>(){ 
                // Initializing the dictionary with the element values
    {"C",0},
    {"H",0},
    {"N",0},
    {"O",0},
    {"F",0},
    {"Cl",0},
    {"Br",0},
    {"I",0},
    {"S",0},
    {"P",0},
    {"Si",0}

   };
            elementHash["C"] = new string[2] { "12C", "13C" };
            elementHash["H"] = new string[2] { "1H", "2H(D)" };
            elementHash["N"] = new string[2] { "14N", "15N" };
            elementHash["O"] = new string[3] { "16O", "17O", "18O" };
            elementHash["F"] = new string[1] { "19F" };
            elementHash["Cl"] = new string[2] { "35Cl", "37Cl" };
            elementHash["Br"] = new string[2] { "79Br", "81Br" };
            elementHash["I"] = new string[1] { "127I" };
            elementHash["S"] = new string[4] { "32S", "33S", "34S", "35S" };
            elementHash["P"] = new string[2] { "31P", "32P" };
            elementHash["Si"] = new string[3] { "28Si", "29Si", "30Si" };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void initiateseconddatagrid() // Creates the data for the isotopes and fragments 
        {
            int largestElement = 0;
            var enteredElements = elementValues.Where(kvp => kvp.Value >= 1).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            var sortedElements = from element in enteredElements orderby element.Value descending select element;
            Console.WriteLine(sortedElements);
            largestElement = sortedElements.First().Value;
            dataGridView2.ColumnCount += largestElement;

            int columnOffset = 3;
            int Rowdaughterion;
            for (int firstRowIndex = 0; firstRowIndex < dataGridView1.Rows.Count; firstRowIndex++)
            {
               
                Int32.TryParse((String)dataGridView1[2, firstRowIndex].Value, out Rowdaughterion);
                dataGridView2.Rows.Add(dataGridView1[1, firstRowIndex].Value);
                foreach (KeyValuePair<string, int> entry in sortedElements)
                {
                    for (int column = columnOffset; column < entry.Value + columnOffset; column++)
                    {
                        int lastRow = dataGridView2.Rows.Count - 1; //get the last row in our second datagrid
                        dataGridView2[column, lastRow].Value = entry.Key + "#" + (column - (columnOffset - 1));

                    }
                    dataGridView2.Rows.Add(2);
                }
            }




        }

        private void constructMolecularFormula(Dictionary<string, int> elements) // creates the molecular formula to be displayed
        {
            String formula = "";
            foreach (KeyValuePair<string, int> entry in elements)
            {
                if (entry.Value == 1)
                {
                    formula += entry.Key;
                }
                else
                {
                    formula += entry.Key + entry.Value;
                }
            }
            molfur.Text = formula;
        }
        private void populatemolecularheaders() // creates headers based on elements presenting the molecular formula
        {
            var enteredElements = elementValues.Where(kvp => kvp.Value >= 1).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            constructMolecularFormula(enteredElements);
        }

        private void populateElementValuesDic() // reads the number of elements entered by user and populate into the dictionary
        {
            elementValues["C"] = Ccarbon;
            elementValues["H"] = Hhydrogen;
            elementValues["N"] = Nnitrogen;
            elementValues["O"] = Ooxygen;
            elementValues["F"] = Fflourine;
            elementValues["Cl"] = Cchlorine;
            elementValues["Br"] = Bbromine;
            elementValues["I"] = Iiodine;
            elementValues["S"] = Ssulfur;
            elementValues["P"] = Pphosphorus;
            elementValues["Si"] = Ssilicon;

        }

        private void addRows()
        {
            dataGridView1.Rows.Add(IsotopewithavailableMSdata);
        }

        private void clearColumnsForGrid2()
        {
            for (int columnIndx = dataGridView2.Columns.Count - 1; columnIndx >= 3; columnIndx--)
            {
                dataGridView2.Columns.RemoveAt(columnIndx);
            }
        }

        private void Okay_Click(object sender, EventArgs e) //
        {
            if (dataGridView2.Columns.Count > 3 && dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows.Clear();
                clearColumnsForGrid2();
            }
            
            IsCompoundName = tbCompound.Text;
            MolecularFormula = molfur.Text;
            // TryParse converts string to integer to represent the type of what you are looking for
            Double.TryParse(molwei.Text, out MolecularWeight);
            Int32.TryParse(carb.Text, out Ccarbon);
            Int32.TryParse(hydr.Text, out Hhydrogen);
            Int32.TryParse(nitro.Text, out Nnitrogen);
            Int32.TryParse(oxyg.Text, out Ooxygen);
            Int32.TryParse(flour.Text, out Fflourine);
            Int32.TryParse(chlo.Text, out Cchlorine);
            Int32.TryParse(brom.Text, out Bbromine);
            Int32.TryParse(iodi.Text, out Iiodine);
            Int32.TryParse(sulf.Text, out Ssulfur);
            Int32.TryParse(phos.Text, out Pphosphorus);
            Int32.TryParse(silic.Text, out Ssilicon);
            Double.TryParse(combms.Text, out CompoundBaseMass);
            Int32.TryParse(framsbms.Text, out FragmentMS);
            Int32.TryParse(isomsdata.Text, out IsotopewithavailableMSdata);
            populateElementValuesDic();
            initiateseconddatagrid();
            populatemolecularheaders();
        }

        private void framsbms_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(isomsdata.Text, out IsotopewithavailableMSdata);
            addRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

    }
}