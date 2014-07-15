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
            this.tbCompound = new System.Windows.Forms.TextBox();
            this.lbCompound = new System.Windows.Forms.Label();
            this.Okay = new System.Windows.Forms.Button();
            this.molfur = new System.Windows.Forms.TextBox();
            this.lbMolecularFormula = new System.Windows.Forms.Label();
            this.molwei = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.carb = new System.Windows.Forms.TextBox();
            this.hydr = new System.Windows.Forms.TextBox();
            this.nitro = new System.Windows.Forms.TextBox();
            this.oxyg = new System.Windows.Forms.TextBox();
            this.flour = new System.Windows.Forms.TextBox();
            this.chlo = new System.Windows.Forms.TextBox();
            this.brom = new System.Windows.Forms.TextBox();
            this.iodi = new System.Windows.Forms.TextBox();
            this.sulf = new System.Windows.Forms.TextBox();
            this.phos = new System.Windows.Forms.TextBox();
            this.silic = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCompound
            // 
            this.tbCompound.Location = new System.Drawing.Point(16, 47);
            this.tbCompound.Name = "tbCompound";
            this.tbCompound.Size = new System.Drawing.Size(245, 20);
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
            this.lbCompound.Click += new System.EventHandler(this.label1_Click);
            // 
            // Okay
            // 
            this.Okay.Location = new System.Drawing.Point(695, 155);
            this.Okay.Name = "Okay";
            this.Okay.Size = new System.Drawing.Size(75, 50);
            this.Okay.TabIndex = 2;
            this.Okay.Text = "Process Information";
            this.Okay.UseVisualStyleBackColor = true;
            this.Okay.Click += new System.EventHandler(this.Okay_Click);
            // 
            // molfur
            // 
            this.molfur.Location = new System.Drawing.Point(279, 47);
            this.molfur.Name = "molfur";
            this.molfur.Size = new System.Drawing.Size(123, 20);
            this.molfur.TabIndex = 3;
            // 
            // lbMolecularFormula
            // 
            this.lbMolecularFormula.AutoSize = true;
            this.lbMolecularFormula.Location = new System.Drawing.Point(286, 26);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Atoms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "C (Carbon)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "H (Hydrogen)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "N (Nitrogen)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "O (Oxygen)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "F (Flourine)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cl (Chlorine)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Br (Bromine)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(155, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "I (Iodine)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "S (Sulfur)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(153, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "P (Phosphorus)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Si (Silicon)";
            // 
            // carb
            // 
            this.carb.Location = new System.Drawing.Point(100, 108);
            this.carb.Name = "carb";
            this.carb.Size = new System.Drawing.Size(49, 20);
            this.carb.TabIndex = 20;
            // 
            // hydr
            // 
            this.hydr.Location = new System.Drawing.Point(100, 135);
            this.hydr.Name = "hydr";
            this.hydr.Size = new System.Drawing.Size(49, 20);
            this.hydr.TabIndex = 21;
            // 
            // nitro
            // 
            this.nitro.Location = new System.Drawing.Point(100, 168);
            this.nitro.Name = "nitro";
            this.nitro.Size = new System.Drawing.Size(49, 20);
            this.nitro.TabIndex = 22;
            // 
            // oxyg
            // 
            this.oxyg.Location = new System.Drawing.Point(100, 197);
            this.oxyg.Name = "oxyg";
            this.oxyg.Size = new System.Drawing.Size(49, 20);
            this.oxyg.TabIndex = 23;
            // 
            // flour
            // 
            this.flour.Location = new System.Drawing.Point(396, 171);
            this.flour.Name = "flour";
            this.flour.Size = new System.Drawing.Size(49, 20);
            this.flour.TabIndex = 24;
            // 
            // chlo
            // 
            this.chlo.Location = new System.Drawing.Point(396, 102);
            this.chlo.Name = "chlo";
            this.chlo.Size = new System.Drawing.Size(49, 20);
            this.chlo.TabIndex = 25;
            // 
            // brom
            // 
            this.brom.Location = new System.Drawing.Point(237, 105);
            this.brom.Name = "brom";
            this.brom.Size = new System.Drawing.Size(52, 20);
            this.brom.TabIndex = 26;
            // 
            // iodi
            // 
            this.iodi.Location = new System.Drawing.Point(237, 139);
            this.iodi.Name = "iodi";
            this.iodi.Size = new System.Drawing.Size(52, 20);
            this.iodi.TabIndex = 27;
            // 
            // sulf
            // 
            this.sulf.Location = new System.Drawing.Point(237, 168);
            this.sulf.Name = "sulf";
            this.sulf.Size = new System.Drawing.Size(52, 20);
            this.sulf.TabIndex = 28;
            // 
            // phos
            // 
            this.phos.Location = new System.Drawing.Point(237, 198);
            this.phos.Name = "phos";
            this.phos.Size = new System.Drawing.Size(52, 20);
            this.phos.TabIndex = 29;
            // 
            // silic
            // 
            this.silic.Location = new System.Drawing.Point(396, 135);
            this.silic.Name = "silic";
            this.silic.Size = new System.Drawing.Size(52, 20);
            this.silic.TabIndex = 30;
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
            this.label16.Location = new System.Drawing.Point(547, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Compound Base Mass";
            // 
            // combms
            // 
            this.combms.Location = new System.Drawing.Point(666, 44);
            this.combms.Name = "combms";
            this.combms.Size = new System.Drawing.Size(76, 20);
            this.combms.TabIndex = 34;
            // 
            // framsbms
            // 
            this.framsbms.AutoSize = true;
            this.framsbms.Location = new System.Drawing.Point(484, 80);
            this.framsbms.Name = "framsbms";
            this.framsbms.Size = new System.Drawing.Size(176, 13);
            this.framsbms.TabIndex = 35;
            this.framsbms.Text = "Fragment in MS base of Compound ";
            this.framsbms.Click += new System.EventHandler(this.framsbms_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(666, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 20);
            this.textBox2.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(484, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(165, 26);
            this.label18.TabIndex = 37;
            this.label18.Text = "Isotope with available MS data\r\n(including MS of base compound)\r\n";
            // 
            // isomsdata
            // 
            this.isomsdata.Location = new System.Drawing.Point(666, 117);
            this.isomsdata.Name = "isomsdata";
            this.isomsdata.Size = new System.Drawing.Size(88, 20);
            this.isomsdata.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Isotope,
            this.IsotopeMass,
            this.BaseFragments});
            this.dataGridView1.Location = new System.Drawing.Point(785, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(303, 169);
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
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Baseparentionmass,
            this.Daughterionmass,
            this.Abundance});
            this.dataGridView2.Location = new System.Drawing.Point(3, 224);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(1095, 275);
            this.dataGridView2.TabIndex = 40;
            // 
            // Baseparentionmass
            // 
            this.Baseparentionmass.HeaderText = "Base /Parent ion mass";
            this.Baseparentionmass.Name = "Baseparentionmass";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 502);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.isomsdata);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.framsbms);
            this.Controls.Add(this.combms);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.silic);
            this.Controls.Add(this.phos);
            this.Controls.Add(this.sulf);
            this.Controls.Add(this.iodi);
            this.Controls.Add(this.brom);
            this.Controls.Add(this.chlo);
            this.Controls.Add(this.flour);
            this.Controls.Add(this.oxyg);
            this.Controls.Add(this.nitro);
            this.Controls.Add(this.hydr);
            this.Controls.Add(this.carb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox carb;
        private System.Windows.Forms.TextBox hydr;
        private System.Windows.Forms.TextBox nitro;
        private System.Windows.Forms.TextBox oxyg;
        private System.Windows.Forms.TextBox flour;
        private System.Windows.Forms.TextBox chlo;
        private System.Windows.Forms.TextBox brom;
        private System.Windows.Forms.TextBox iodi;
        private System.Windows.Forms.TextBox sulf;
        private System.Windows.Forms.TextBox phos;
        private System.Windows.Forms.TextBox silic;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Baseparentionmass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daughterionmass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abundance;
    }
}

