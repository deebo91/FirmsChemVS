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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Isotope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsotopeMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseFragments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Baseparentionmass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daughterionmass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abundance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.elementGrid = new System.Windows.Forms.DataGridView();
            this.elements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAtoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWriterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataWriterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCompound
            // 
            this.tbCompound.Location = new System.Drawing.Point(16, 47);
            this.tbCompound.Name = "tbCompound";
            this.tbCompound.Size = new System.Drawing.Size(219, 20);
            this.tbCompound.TabIndex = 0;
            // 
            // lbCompound
            // 
            this.lbCompound.AutoSize = true;
            this.lbCompound.Location = new System.Drawing.Point(84, 26);
            this.lbCompound.Name = "lbCompound";
            this.lbCompound.Size = new System.Drawing.Size(92, 13);
            this.lbCompound.TabIndex = 1;
            this.lbCompound.Text = "Compound Name ";
            // 
            // Okay
            // 
            this.Okay.Location = new System.Drawing.Point(712, 234);
            this.Okay.Name = "Okay";
            this.Okay.Size = new System.Drawing.Size(75, 50);
            this.Okay.TabIndex = 2;
            this.Okay.Text = "Process Information";
            this.Okay.UseVisualStyleBackColor = true;
            this.Okay.Click += new System.EventHandler(this.ProcessCompoundName);
            // 
            // molfur
            // 
            this.molfur.Location = new System.Drawing.Point(256, 47);
            this.molfur.Name = "molfur";
            this.molfur.Size = new System.Drawing.Size(123, 20);
            this.molfur.TabIndex = 3;
            // 
            // lbMolecularFormula
            // 
            this.lbMolecularFormula.AutoSize = true;
            this.lbMolecularFormula.Location = new System.Drawing.Point(267, 26);
            this.lbMolecularFormula.Name = "lbMolecularFormula";
            this.lbMolecularFormula.Size = new System.Drawing.Size(93, 13);
            this.lbMolecularFormula.TabIndex = 4;
            this.lbMolecularFormula.Text = "Molecular Formula";
            // 
            // molwei
            // 
            this.molwei.Location = new System.Drawing.Point(424, 47);
            this.molwei.Name = "molwei";
            this.molwei.Size = new System.Drawing.Size(100, 20);
            this.molwei.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Molecular Weight";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(229, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(243, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "FAST ISOTOPE RATIO MASS SPECTROSCOPY\r\n";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(665, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Compound Base Mass";
            // 
            // combms
            // 
            this.combms.Location = new System.Drawing.Point(784, 111);
            this.combms.Name = "combms";
            this.combms.Size = new System.Drawing.Size(76, 20);
            this.combms.TabIndex = 34;
            // 
            // framsbms
            // 
            this.framsbms.AutoSize = true;
            this.framsbms.Location = new System.Drawing.Point(605, 147);
            this.framsbms.Name = "framsbms";
            this.framsbms.Size = new System.Drawing.Size(173, 13);
            this.framsbms.TabIndex = 35;
            this.framsbms.Text = "Fragment in MS base of Compound";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(784, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(613, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(165, 26);
            this.label18.TabIndex = 37;
            this.label18.Text = "Isotope with available MS data\r\n(including MS of base compound)\r\n";
            // 
            // isomsdata
            // 
            this.isomsdata.Location = new System.Drawing.Point(784, 176);
            this.isomsdata.Name = "isomsdata";
            this.isomsdata.Size = new System.Drawing.Size(40, 20);
            this.isomsdata.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Isotope,
            this.IsotopeMass,
            this.BaseFragments});
            this.dataGridView1.Location = new System.Drawing.Point(256, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(303, 204);
            this.dataGridView1.TabIndex = 39;
            // 
            // Isotope
            // 
            this.Isotope.HeaderText = "Isotope";
            this.Isotope.Name = "Isotope";
            // 
            // IsotopeMass
            // 
            this.IsotopeMass.HeaderText = "Isotope Mass";
            this.IsotopeMass.Name = "IsotopeMass";
            // 
            // BaseFragments
            // 
            this.BaseFragments.HeaderText = "Base Fragments";
            this.BaseFragments.Name = "BaseFragments";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Baseparentionmass,
            this.Daughterionmass,
            this.Abundance});
            this.dataGridView2.Location = new System.Drawing.Point(16, 290);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(1082, 200);
            this.dataGridView2.TabIndex = 40;
            // 
            // Baseparentionmass
            // 
            this.Baseparentionmass.HeaderText = "Base /Parent ion mass";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 50);
            this.button2.TabIndex = 42;
            this.button2.Text = "Export To Excel";
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
            this.elementGrid.Location = new System.Drawing.Point(16, 80);
            this.elementGrid.Name = "elementGrid";
            this.elementGrid.Size = new System.Drawing.Size(219, 204);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 502);
            this.Controls.Add(this.elementGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataWriterBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isotope;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsotopeMass;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseFragments;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baseparentionmass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daughterionmass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abundance;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView elementGrid;
        private System.Windows.Forms.BindingSource dataWriterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn elements;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAtoms;
    }
}

