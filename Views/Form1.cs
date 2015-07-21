﻿// Importing system library
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmsChemVS.Repositories;
using FirmsChemVS.Services;
using DoddleReport;
using DoddleReport.OpenXml;
using System.Data.SqlClient;
using System.Windows;
using System.Data.OleDb;





namespace FirmsChemVS
{
    public partial class Form1 : Form
    {
        FirmsChemFacade facade = FirmsChemFacade.Instance;
        // Declearing all the variables as strings, doubles or integers
        String IsCompoundName; // compound name
        IsotopeService isotopeService = IsotopeService.Instance;
        Calculations calculationSevice = Calculations.Instance;
        BaseTableMassService baseTableService = BaseTableMassService.Instance;

        int[] rowWindow = new int[2] { -1, -1 };

        // Integer values for the number of each atom present in the compound

        int IsotopewithavailableMSdata;

        public Form1()
        {
            InitializeComponent();
            facade.InitGrids(elementGrid);
        }

        private void LayoutCompoundTable() // Creates the data for the isotopes and fragments 
        {
            
            int lastColumn = dataGridView2.Columns.Count;
            foreach (DataGridViewRow entry in elementGrid.Rows)
            {
                int numberOfAtoms = Convert.ToInt32(entry.Cells["numberOfAtoms"].Value);
                if (numberOfAtoms > 0)
                {
                    for (int index = 1; index <= numberOfAtoms; index++)
                    {
                        string elementSymbol = (string)entry.Cells["elements"].Value;
                        DataGridViewCheckBoxColumn columnToAdd = new DataGridViewCheckBoxColumn();
                        columnToAdd.HeaderText = elementSymbol + index;
                        columnToAdd.Name = elementSymbol + index;
                        int columnId = dataGridView2.Columns.Add(columnToAdd);
                    }
                }
            }

        }

        private void addRows()
        {
            baseMassCalcTable.Rows.Add(IsotopewithavailableMSdata);
        }

        private void clearColumnsForGrid2()
        {
            for (int columnIndx = dataGridView2.Columns.Count - 1; columnIndx >= 5; columnIndx--)
            {
                dataGridView2.Columns.RemoveAt(columnIndx);
            }
        }

        private void ProcessCompoundName(object sender, EventArgs e)
        {
            if (dataGridView2.Columns.Count > 5)
            {
                clearColumnsForGrid2();
            }

            IsCompoundName = tbCompound.Text;
            // TryParse converts string to integer to represent the type of what you are looking for
            molwei.Text = facade.CalculateMolecularWeight(elementGrid).ToString();
            molfur.Text = facade.CalculateMolecularFormula(elementGrid);
            //facade.CalculateIsotopeCombinations(elementGrid);
            LayoutCompoundTable();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(isomsdata.Text, out IsotopewithavailableMSdata);
            addRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baseMassCalcTable.Rows.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            baseMassCalcTable.Rows.Clear();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            bool isReportSaved = facade.exportDataSetToExcelFile(dataGridView2);
            if (isReportSaved)
            {
                MessageBox.Show("File has been saved under My Documents");
            }
            else
            {
                MessageBox.Show("Unable to save file");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < baseMassCalcTable.Rows.Count; n++)
            {
                DataGridViewRow row = baseMassCalcTable.Rows[n];
                {

                    this.chart1.Series[0].Points.AddXY("m/z" + (n + 1), Convert.ToDouble(baseMassCalcTable.Rows[n].Cells[3].Value));

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IsotopeService isotopeService = new IsotopeService();
            ArrayList ionBaseMassList = new ArrayList();
            double fA; //fractional abundance of the most stable isotope of the atom
            double fA1; // fractional abundance of the second isotope 
            double fB; // fractional abundance of the most stable isotope of the second atom
            double fB1; // fractional abundace of the second isotope of the second atom
            double fB2 = 0; //S34 of sulphur
            int m; int n; int j; int l;
            double mu1;
            double alph;
            double CalAbu = 0;
            double AbunTotal;
            int currentRowInBassMassTable = 0;
            DataGridViewRow bassMassRow = null;
            alph = 0; AbunTotal = 0; m = 0; n = 0; fA = 0; fA1 = 0; fB = 0; fB1 = 0; j = 0; l = 0;

            var elementMap = DataGridViewHelper.elementDataGridToDictionary(elementGrid);
            var isotopesForA = isotopeService.getAllIsotopesForAtom(elementMap.First().Key);
            var isotopesForB = isotopeService.getAllIsotopesForAtom(elementMap.Last().Key);
            var totalExperimentalAbundance = DataGridViewHelper.ColumnToList(dataGridView2, "Abundance");

            foreach (string item in totalExperimentalAbundance)
            {
                AbunTotal += Convert.ToDouble(item);
            }
           

            //sets j and l to the number of atoms of the molecule
            j = elementMap.First().Value;
            l = elementMap.Last().Value;
            fA = (double)isotopesForA.First().abundance / 100f;
            fA1 = (double)isotopesForA.Last().abundance / 100f;
            fB = (double)isotopesForB.First().abundance / 100f;
            fB1 = (double)isotopesForB.Last().abundance / 100f;

           var sulphur34 = (isotopesForB.Find(x => x.isotopeNumber == 34));
            if(sulphur34 != null){
                fB2 = (double)sulphur34.abundance / 100f;
            }



            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if(row.Cells["Abundance"].Value == null){
                    return;
                }
                if (currentRowInBassMassTable < baseMassCalcTable.Rows.Count)
                {
                    bassMassRow = baseMassCalcTable.Rows[currentRowInBassMassTable];
                    currentRowInBassMassTable = currentRowInBassMassTable + 1;
                }
                else
                {
                    currentRowInBassMassTable = 0;
                    bassMassRow = baseMassCalcTable.Rows[currentRowInBassMassTable];
                }

               
                m = Convert.ToInt32(bassMassRow.Cells["mValues"].Value);
                n = Convert.ToInt32(bassMassRow.Cells["nValues"].Value);
                alph = Convert.ToDouble(bassMassRow.Cells["alphas"].Value);
                var baseMass = dataGridView2.Rows[row.Index].Cells[0].Value;

                if (baseMass != null)
                {
                    ionBaseMassList.Add(baseMass);
                }

                if (ionBaseMassList.Count == 1)
                {
                        mu1 =  alph / ((Math.Pow(fA, j) * fB1 * Math.Pow(fB, l - 1)) + (fA1 * Math.Pow(fA, j - 1) * Math.Pow(fB, l)));
                        CalAbu = mu1 * AbunTotal;
                }
                else if (ionBaseMassList.Count == 2)
                {
                    if (!(elementMap.ContainsKey("O") || elementMap.ContainsKey("S") || elementMap.ContainsKey("Br") || elementMap.ContainsKey("Cl")))
                    {

                        mu1 = alph / ((Math.Pow(fA1, 2) * Math.Pow(fA, j - 2) * Math.Pow(fB, l)) + (Math.Pow(fB1, 2) *
                                Math.Pow(fB, l - 2) * Math.Pow(fA, j)) + (fA1 * fB1 * Math.Pow(fA, j - 1) * Math.Pow(fB, l - 1)));
                        CalAbu = mu1 * AbunTotal;

                    }
                    else if (elementMap.ContainsKey("S"))
                    {
                            mu1 = alph / ((Math.Pow(fA1, 2) * Math.Pow(fB, l) * Math.Pow(fA, j - 2)) + (Math.Pow(fA, j) * fB2 * Math.Pow(
                                fB, l - 1)) + (fA1 * fB1 * Math.Pow(fA, j - 1) * Math.Pow(fB, l - 1)) + (Math.Pow(fA, j) * Math.Pow(fB1, 2) * Math.Pow
                                (fB, l - 2)));
                            CalAbu = mu1 * AbunTotal;
                        
                    }
                    else if (elementMap.ContainsKey("O") || elementMap.ContainsKey("Br") || elementMap.ContainsKey("Cl"))
                    {
                        mu1 = alph / ((fA1 * Math.Pow(fA, j - 1) * Math.Pow(fB, l)) + (fB1 * Math.Pow(fB, l - 1) * Math.Pow(fA, j)));
                        CalAbu = mu1 * AbunTotal;
                    }
                    else return;
                }
                else if (ionBaseMassList.Count == 3)
                {
                    if (!(elementMap.ContainsKey("O") || elementMap.ContainsKey("S") || elementMap.ContainsKey("Br") || elementMap.ContainsKey("Cl")))
                    {
                        mu1 = alph / ((Math.Pow(fA1, 2) * Math.Pow(fA, j - 2) * fB1 * Math.Pow(fB, n - 1)) + (fA1 * Math.Pow(fA, j - 1) *
                                Math.Pow(fB1, 2) * Math.Pow(fB, l - 2)) + (Math.Pow(fA1, 3) * Math.Pow(fA, j - 3) * Math.Pow(fB, l)) + (Math.Pow(fA, j) *
                                Math.Pow(fB1, 3) * Math.Pow(fB, l - 3)));
                        CalAbu = mu1 * AbunTotal;
                    }
                    else if (elementMap.ContainsKey("S") && !(elementMap.ContainsKey("O") || elementMap.ContainsKey("Br") || elementMap.ContainsKey("Cl")))
                    {
                        mu1 = alph / ((fA1 * Math.Pow(fA, j - 1) * fB2 * Math.Pow(fB, l - 1)) + (Math.Pow(fA1, 3) * Math.Pow(fA, j - 3) * Math.Pow
                                (fB, l)) + (Math.Pow(fA, j) * Math.Pow(fB1, 3) * Math.Pow(fB, l - 3)) + (Math.Pow(fA, j) * fB1 * fB2 * Math.Pow(
                                fB, l - 2)) + (Math.Pow(fA1, 2) * Math.Pow(fA, j - 2) * fB1 * Math.Pow(fB, l - 1)) + (fA1 * Math.Pow(fA, j - 1) * Math.Pow
                                (fB1, 2) * Math.Pow(fB, l - 2)));
                        CalAbu = mu1 * AbunTotal;
                    }
                    else if ((elementMap.ContainsKey("O") || elementMap.ContainsKey("Br") || elementMap.ContainsKey("Cl")) && !elementMap.ContainsKey("S"))
                    {
                        mu1 = alph / ((Math.Pow(fA1, 3) * Math.Pow(fA, j - 3) * Math.Pow(fB, l)) + (fA1 * Math.Pow(fA, j - 1)
                                 * fB1 * Math.Pow(fB, l - 1)));
                        CalAbu = mu1 * AbunTotal;
                    }
                    else return;
                }
                else
                {
                    return;
                }


                dataGridView2.Rows[row.Index].Cells["CalculatedAbundance"].Value = CalAbu;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            if (rowWindow[0] == -1)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value != null && rowWindow[0] == -1)
                    {
                        rowWindow[0] = row.Index;
                    }
                    else if (row.Cells[0].Value != null && rowWindow[1] == -1)
                    {
                        rowWindow[1] = row.Index;
                    }

                    if (rowWindow[0] != -1 && rowWindow[1] != -1)
                    {
                        break;
                    }
                }
            }

            for (int index = 0; index < rowWindow[1] - rowWindow[0]; index++)
            {
                int currentRow = rowWindow[0] + index;
                chart1.Series[0].Points.AddXY(index, dataGridView2.Rows[currentRow].Cells[2].Value);
                chart1.Series[1].Points.AddXY(index, dataGridView2.Rows[currentRow].Cells[4].Value);
            }
        }

        private ArrayList processCurrentColumn(DataGridViewColumn column)
        {
            ArrayList numberList = new ArrayList();
            for (int rowCount = 0; rowCount < dataGridView2.Rows.Count; rowCount++)
            {
                if (dataGridView2.Rows[rowCount].Cells["Abundance"].Value != null)
                {
                    numberList.Add(dataGridView2.Rows[rowCount].Cells["Abundance"].Value);
                }
            }

            return numberList;
        }
        private void isomsdata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                String numberOfIsotopeData = isomsdata.Text;
                if (numberOfIsotopeData == null || numberOfIsotopeData.Equals(""))
                {
                    return;
                }
                else
                {
                    int totalNumberToCopy = Convert.ToInt32(numberOfIsotopeData);
                    ArrayList abundancesToCopy = processCurrentColumn(dataGridView2.Columns["Abundance"]);
                    dataGridView2.Rows.Add(totalNumberToCopy * abundancesToCopy.Count);
                    int row = abundancesToCopy.Count;
                    for (int index = 0; index < totalNumberToCopy; index++)
                    {
                        for (int abundanceIndex = 0; abundanceIndex < abundancesToCopy.Count; abundanceIndex++)
                        {
                            dataGridView2[2, row].Value = abundancesToCopy[abundanceIndex];
                            row++;
                        }
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for (int n = 0; n < baseMassCalcTable.Rows.Count; n++)
            {
                DataGridViewRow row = baseMassCalcTable.Rows[n];
                {

                    this.chart1.Series[0].Points.AddXY("m/z" + (n + 1), Convert.ToDouble(baseMassCalcTable.Rows[n].Cells[3].Value));

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in baseMassCalcTable.Rows)
            {
                double sumadd = 0;
                int n = 0;
                for (long i = 0; i < baseMassCalcTable.Rows.Count; ++i)
                {
                    sumadd += Convert.ToDouble(baseMassCalcTable.Rows[n].Cells[3].Value);
                }

            }

        }

        private void baseMassCalcTable_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            facade.abundanceForRow(baseMassCalcTable);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            baseMassCalcTable.Rows.Add();
            baseTableService.TableCount = baseMassCalcTable.Rows.Count;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string PathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox1path.Text + "; Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(PathConn);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + textBox3Sheet.Text + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        
        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1path.Text = openFileDialog1.FileName;
            }
        }

        private Dictionary<int, double> sumUpAbundances()
        {
            var result = new Dictionary<int, double>();
            int lastIndex = 0;
           List<double> abundances = DataGridViewHelper.ColumnToList(dataGridView2, "Abundance").ToArray().Select(s => Convert.ToDouble(s)).ToList();
           List<int> baseParentIon = DataGridViewHelper.ColumnToList(dataGridView2, "Baseparentionmass").ToArray().Select(s => Convert.ToInt32(s)).ToList();
      

           foreach (int ion in baseParentIon)
           {
               List<double> subsetOfAbundance = abundances.GetRange(lastIndex, baseTableService.TableCount);
               result.Add(ion, subsetOfAbundance.Sum());
                lastIndex += baseTableService.TableCount;
            }


            return result;
        }

        private void calculateAbundancePerLine(object sender, EventArgs e)
        {
            int parentIonTotal = 0;
            double alpha;
            int positionOfBaseMassCalcTable;
            var allIsotopes = isotopeService.getAllIsotopesInIsotopeSymbols(DataGridViewHelper.elementDataGridToDictionary(elementGrid).Keys.ToArray());
            var abundanceTotals = sumUpAbundances();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Abundance"].Value != null)
                {

                    positionOfBaseMassCalcTable = baseTableService.incrementBaseTableMassPosition();
                    if (positionOfBaseMassCalcTable == -9)
                    {
                        MessageBox.Show("Seems like there are no available alphas, please enter abundances in the above table");
                        return;
                    }
                    alpha = Convert.ToDouble(baseMassCalcTable.Rows[positionOfBaseMassCalcTable].Cells[3].Value);

                    if (row.Cells["Baseparentionmass"].Value != null)
                    {
                        parentIonTotal = Convert.ToInt32(row.Cells["Baseparentionmass"].Value);
                    }

                    Dictionary<string, int> rowElements = new Dictionary<string, int>();
                    Dictionary<string, object> possibleIsotopesPerElement = new Dictionary<string, object>();


                    for (int index = 5; index < dataGridView2.ColumnCount; index++)
                    {
                        if (row.Cells[index].Value == null)
                        {
                            break;
                        }
                        if ((bool)(row.Cells[index] as DataGridViewCheckBoxCell).Value == true)
                        {
                            int retrievedValue;
                            string headerElement = dataGridView2.Columns[index].HeaderText.Substring(0, (dataGridView2.Columns[index].HeaderText.Length - 1));
                            if (rowElements.TryGetValue(headerElement, out retrievedValue))
                            {
                                rowElements[headerElement] = retrievedValue + 1;
                            }
                            else
                            {
                                rowElements.Add(headerElement, 1);
                            }
                        }
                    }

                    foreach (string item in rowElements.Keys)
                    {

                        int[] listofIsotopeInts = isotopeService.getAllIsotopesForAtom(item).Select(x => x.isotopeNumber ?? 0).OrderByDescending(value => value).ToArray();

                        possibleIsotopesPerElement.Add(item, listofIsotopeInts);
                    }
                    int[] isotopeList = new int[] { };
                    foreach (int[] item in possibleIsotopesPerElement.Values)
                    {
                        isotopeList = isotopeList.Concat(item).ToArray();
                    }
                    int[] counts = Enumerable.Repeat(0, isotopeList.Length).ToArray();
                    int daughterIon = Convert.ToInt32(row.Cells["Daughterionmass"].Value);
                    List<Dictionary<int, int>> numerator = new List<Dictionary<int, int>>();
                    List<Dictionary<int, int>> denominator = new List<Dictionary<int, int>>();
                    calculationSevice.CurrentRowElements = rowElements;
                    calculationSevice.isotopeCombinations(isotopeList.OrderByDescending(i =>i).ToArray(), counts.ToArray(), 0, daughterIon, numerator);
                    calculationSevice.CurrentRowElements = DataGridViewHelper.elementDataGridToDictionary(elementGrid);
                    calculationSevice.isotopeCombinations(allIsotopes, Enumerable.Repeat(0, allIsotopes.Length).ToArray(), 0, parentIonTotal, denominator);
                    calculationSevice.CurrentRowElements = null;
                    row.Cells["CalculatedAbundance"].Value = abundanceTotals[parentIonTotal] * (alpha * calculationSevice.calculateIsotopeDividend(numerator, allIsotopes)) / calculationSevice.calculateIsotopeDividend(denominator, allIsotopes);
                }
            }

            baseTableService.resetBaseTablePosition();
        }

        

        
    
         
        










    }
}