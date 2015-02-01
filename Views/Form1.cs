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




namespace FirmsChemVS
{
    public partial class Form1 : Form
    {
        FirmsChemFacade facade = FirmsChemFacade.Instance;
        // Declearing all the variables as strings, doubles or integers
        String IsCompoundName;                  // compound name
        // Integer values for the number of each atom present in the compound

        int IsotopewithavailableMSdata;
        
        public Form1()
        {
            InitializeComponent();
            facade.InitGrids(elementGrid);
        }

        private void LayoutCompoundTable() // Creates the data for the isotopes and fragments 
        {
            int lastColumn = dataGridView2.ColumnCount;
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
            dataGridView1.Rows.Add(IsotopewithavailableMSdata);
        }

        private void clearColumnsForGrid2()
        {
            for (int columnIndx = dataGridView2.Columns.Count - 1; columnIndx >= 3; columnIndx--)
            {
                dataGridView2.Columns.RemoveAt(columnIndx);
            }
        }

        private void ProcessCompoundName(object sender, EventArgs e)
        {
            if (dataGridView2.Columns.Count > 3)
            {
                clearColumnsForGrid2();
            }

            IsCompoundName = tbCompound.Text;
            // TryParse converts string to integer to represent the type of what you are looking for
            molwei.Text = facade.CalculateMolecularWeight(elementGrid).ToString();
            molfur.Text = facade.CalculateMolecularFormula(elementGrid);
            LayoutCompoundTable();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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

       
    }
}