﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DoddleReport;
using DoddleReport.OpenXml;

namespace FirmsChemVS.Repositories
{
    class DataReporter
    {
        DataTable dataForGrid2;

        public DataTable DataForGrid2
        {
            get { return dataForGrid2; }
        }

        public DataReporter(DataGridView gridview)
        {
            dataForGrid2 = new DataTable();
            convertDatagridToDatatable(gridview);
        }

        public DataReporter()
        {

        }

        public void setSupplimentaryInfo(Dictionary<string,string> test)
        {

        }

        private void convertDatagridToDatatable(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt.Columns.Add(column.HeaderText);
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;     
                }
                dt.Rows.Add(cellValues);
            }
            dataForGrid2 = dt;
        }

        public bool exportDataSetToExcelFile(){

            Random generator = new Random();
            string path = System.IO.Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments), (String.Format("{0}.xlsx", generator.Next(500, 1000))));
            if(dataForGrid2 != null)
            {
                FileStream reportOutput = new FileStream(path, FileMode.Create);
                var report = new Report(DataForGrid2.ToReportSource());
                report.RenderHints.BooleansAsYesNo = true;
                report.RenderHints.Orientation = ReportOrientation.Landscape;
                var writer = new ExcelReportWriter();
                writer.WriteReport(report, reportOutput);
                reportOutput.Close();
                return true;
            } 
            else
            {
                return false;
            }
        }


    }
}
