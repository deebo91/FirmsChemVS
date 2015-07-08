namespace FirmsChemVS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null; // Initiate the components that would be displayed for the view

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) // Starting the drawing mechanism to draw things on the screen
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() // Initialize the components
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbCompound = new System.Windows.Forms.TextBox();
            this.lbCompound = new System.Windows.Forms.Label();
            this.Okay = new System.Windows.Forms.Button();
            this.molfur = new System.Windows.Forms.TextBox();
            this.lbMolecularFormula = new System.Windows.Forms.Label();
            this.molwei = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.combms = new System.Windows.Forms.TextBox();
            this.framsbms = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.isomsdata = new System.Windows.Forms.TextBox();
            this.baseMassCalcTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abundances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alphas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Baseparentionmass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daughterionmass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abundance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculatedAbundance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.elementGrid = new System.Windows.Forms.DataGridView();
            this.elements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAtoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWriterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.addRowToBassMassTable = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1path = new System.Windows.Forms.TextBox();
            this.textBox3Sheet = new System.Windows.Forms.TextBox();
            this.calculateAbundance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baseMassCalcTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataWriterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCompound
            // 
            this.tbCompound.Location = new System.Drawing.Point(16, 36);
            this.tbCompound.Name = "tbCompound";
            this.tbCompound.Size = new System.Drawing.Size(219, 20);
            this.tbCompound.TabIndex = 0;
            // 
            // lbCompound
            // 
            this.lbCompound.AutoSize = true;
            this.lbCompound.Location = new System.Drawing.Point(84, 20);
            this.lbCompound.Name = "lbCompound";
            this.lbCompound.Size = new System.Drawing.Size(92, 13);
            this.lbCompound.TabIndex = 1;
            this.lbCompound.Text = "Compound Name ";
            // 
            // Okay
            // 
            this.Okay.Location = new System.Drawing.Point(97, 251);
            this.Okay.Name = "Okay";
            this.Okay.Size = new System.Drawing.Size(115, 24);
            this.Okay.TabIndex = 2;
            this.Okay.Text = "Process Information";
            this.Okay.UseVisualStyleBackColor = true;
            this.Okay.Click += new System.EventHandler(this.ProcessCompoundName);
            // 
            // molfur
            // 
            this.molfur.Location = new System.Drawing.Point(256, 36);
            this.molfur.Name = "molfur";
            this.molfur.Size = new System.Drawing.Size(123, 20);
            this.molfur.TabIndex = 3;
            // 
            // lbMolecularFormula
            // 
            this.lbMolecularFormula.AutoSize = true;
            this.lbMolecularFormula.Location = new System.Drawing.Point(267, 20);
            this.lbMolecularFormula.Name = "lbMolecularFormula";
            this.lbMolecularFormula.Size = new System.Drawing.Size(93, 13);
            this.lbMolecularFormula.TabIndex = 4;
            this.lbMolecularFormula.Text = "Molecular Formula";
            // 
            // molwei
            // 
            this.molwei.Location = new System.Drawing.Point(424, 36);
            this.molwei.Name = "molwei";
            this.molwei.Size = new System.Drawing.Size(100, 20);
            this.molwei.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Molecular Weight";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(229, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(245, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "FAST ISOTOPE RATIO MASS SPECTROMETRY\r\n";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(450, 247);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Compound Base Mass";
            // 
            // combms
            // 
            this.combms.Location = new System.Drawing.Point(629, 244);
            this.combms.Name = "combms";
            this.combms.Size = new System.Drawing.Size(76, 20);
            this.combms.TabIndex = 34;
            // 
            // framsbms
            // 
            this.framsbms.AutoSize = true;
            this.framsbms.Location = new System.Drawing.Point(450, 273);
            this.framsbms.Name = "framsbms";
            this.framsbms.Size = new System.Drawing.Size(173, 13);
            this.framsbms.TabIndex = 35;
            this.framsbms.Text = "Fragment in MS base of Compound";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(629, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(450, 299);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Isotope with available MS data\r\n";
            // 
            // isomsdata
            // 
            this.isomsdata.Location = new System.Drawing.Point(629, 296);
            this.isomsdata.Name = "isomsdata";
            this.isomsdata.Size = new System.Drawing.Size(76, 20);
            this.isomsdata.TabIndex = 38;
            this.isomsdata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isomsdata_KeyPress);
            // 
            // baseMassCalcTable
            // 
            this.baseMassCalcTable.AllowUserToAddRows = false;
            this.baseMassCalcTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baseMassCalcTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.mValues,
            this.abundances,
            this.alphas});
            this.baseMassCalcTable.Location = new System.Drawing.Point(207, 59);
            this.baseMassCalcTable.Name = "baseMassCalcTable";
            this.baseMassCalcTable.RowHeadersVisible = false;
            this.baseMassCalcTable.Size = new System.Drawing.Size(400, 181);
            this.baseMassCalcTable.TabIndex = 39;
            this.baseMassCalcTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.baseMassCalcTable.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.baseMassCalcTable_RowLeave);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Base ion mass";
            this.Column1.Name = "Column1";
            // 
            // mValues
            // 
            this.mValues.HeaderText = "Daughter Ion Mass";
            this.mValues.Name = "mValues";
            // 
            // abundances
            // 
            this.abundances.HeaderText = "Abundance";
            this.abundances.Name = "abundances";
            // 
            // alphas
            // 
            this.alphas.HeaderText = "Alphas";
            this.alphas.Name = "alphas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Baseparentionmass,
            this.Daughterionmass,
            this.Abundance,
            this.Probability,
            this.CalculatedAbundance});
            this.dataGridView2.Location = new System.Drawing.Point(16, 333);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(1048, 175);
            this.dataGridView2.TabIndex = 40;
            // 
            // Baseparentionmass
            // 
            this.Baseparentionmass.HeaderText = "Parent ion mass";
            this.Baseparentionmass.Name = "Baseparentionmass";
            this.Baseparentionmass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Daughterionmass
            // 
            this.Daughterionmass.HeaderText = "Daughter ion mass";
            this.Daughterionmass.Name = "Daughterionmass";
            // 
            // Abundance
            // 
            this.Abundance.HeaderText = "Abundance";
            this.Abundance.Name = "Abundance";
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Number of Isotopes";
            this.Probability.Name = "Probability";
            // 
            // CalculatedAbundance
            // 
            this.CalculatedAbundance.HeaderText = "Calculated Abundance";
            this.CalculatedAbundance.Name = "CalculatedAbundance";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 42;
            this.button2.Text = "Export Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // elementGrid
            // 
            this.elementGrid.AllowUserToAddRows = false;
            this.elementGrid.AllowUserToDeleteRows = false;
            this.elementGrid.AllowUserToOrderColumns = true;
            this.elementGrid.AllowUserToResizeColumns = false;
            this.elementGrid.AllowUserToResizeRows = false;
            this.elementGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elements,
            this.numberOfAtoms});
            this.elementGrid.Location = new System.Drawing.Point(16, 59);
            this.elementGrid.Name = "elementGrid";
            this.elementGrid.Size = new System.Drawing.Size(185, 181);
            this.elementGrid.TabIndex = 43;
            // 
            // elements
            // 
            this.elements.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.elements.Frozen = true;
            this.elements.HeaderText = "Elements";
            this.elements.Name = "elements";
            this.elements.ReadOnly = true;
            this.elements.Width = 75;
            // 
            // numberOfAtoms
            // 
            this.numberOfAtoms.HeaderText = "Number Of Atoms";
            this.numberOfAtoms.Name = "numberOfAtoms";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(613, 7);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Blue;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Experimental ";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "Calculated";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(414, 233);
            this.chart1.TabIndex = 44;
            this.chart1.Text = "chart1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Spectrum";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(952, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 48;
            this.button6.Text = "Next";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(871, 247);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 49;
            this.button7.Text = "Previous";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // addRowToBassMassTable
            // 
            this.addRowToBassMassTable.Location = new System.Drawing.Point(530, 34);
            this.addRowToBassMassTable.Name = "addRowToBassMassTable";
            this.addRowToBassMassTable.Size = new System.Drawing.Size(75, 23);
            this.addRowToBassMassTable.TabIndex = 50;
            this.addRowToBassMassTable.Text = "Add Row";
            this.addRowToBassMassTable.UseVisualStyleBackColor = true;
            this.addRowToBassMassTable.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(16, 307);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 53;
            this.button9.Text = "Import Excel";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(16, 278);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 54;
            this.button10.Text = "Choose File";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1path
            // 
            this.textBox1path.Location = new System.Drawing.Point(97, 280);
            this.textBox1path.Name = "textBox1path";
            this.textBox1path.Size = new System.Drawing.Size(347, 20);
            this.textBox1path.TabIndex = 55;
            // 
            // textBox3Sheet
            // 
            this.textBox3Sheet.Location = new System.Drawing.Point(97, 307);
            this.textBox3Sheet.Name = "textBox3Sheet";
            this.textBox3Sheet.Size = new System.Drawing.Size(347, 20);
            this.textBox3Sheet.TabIndex = 56;
            // 
            // calculateAbundance
            // 
            this.calculateAbundance.Location = new System.Drawing.Point(218, 252);
            this.calculateAbundance.Name = "calculateAbundance";
            this.calculateAbundance.Size = new System.Drawing.Size(117, 23);
            this.calculateAbundance.TabIndex = 57;
            this.calculateAbundance.Text = "Calculate Abundance";
            this.calculateAbundance.UseVisualStyleBackColor = true;
            this.calculateAbundance.Click += new System.EventHandler(this.calculateAbundancePerLine);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 509);
            this.Controls.Add(this.calculateAbundance);
            this.Controls.Add(this.textBox3Sheet);
            this.Controls.Add(this.textBox1path);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.addRowToBassMassTable);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.elementGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.baseMassCalcTable);
            this.Controls.Add(this.isomsdata);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.framsbms);
            this.Controls.Add(this.combms);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.molwei);
            this.Controls.Add(this.lbMolecularFormula);
            this.Controls.Add(this.molfur);
            this.Controls.Add(this.Okay);
            this.Controls.Add(this.lbCompound);
            this.Controls.Add(this.tbCompound);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.baseMassCalcTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataWriterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCompound;
        private System.Windows.Forms.Label lbCompound;
        private System.Windows.Forms.Button Okay;
        private System.Windows.Forms.TextBox molfur;
        private System.Windows.Forms.Label lbMolecularFormula;
        private System.Windows.Forms.TextBox molwei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox combms;
        private System.Windows.Forms.Label framsbms;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox isomsdata;
        private System.Windows.Forms.DataGridView baseMassCalcTable;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView elementGrid;
        private System.Windows.Forms.BindingSource dataWriterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn elements;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAtoms;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button addRowToBassMassTable;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1path;
        private System.Windows.Forms.TextBox textBox3Sheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn abundances;
        private System.Windows.Forms.DataGridViewTextBoxColumn alphas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baseparentionmass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daughterionmass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abundance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculatedAbundance;
        private System.Windows.Forms.Button calculateAbundance;
    }
}

