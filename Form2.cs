using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmsChemVS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaring experimental data
            double Rtotal; // The ratio total of m+1 divide by base total
            double mu; // The experimental value calculated from the abundance of a fragment divide by total abundance of fragment
            double alpha; // The ratio of base mass abundance to the total abundances of base mass fragments
            double fractx;
            double fracty;
            double fractx2;
            double fracty2;

            // Accepting Values from users
            Rtotal = Convert.ToDouble(Rtotal1.Text);
            mu = Convert.ToDouble(Expmu.Text);
            alpha = Convert.ToDouble(Alpha.Text);


            //Calculating fractions as x, y, 1-x, 1-y

            double sum = alpha + (alpha * Rtotal) - (Rtotal * mu);
            fractx = alpha / sum;
            double sum2 = (fractx * Rtotal) + (2 * fractx) - 1;
            fracty = fractx / sum2;
            fractx2 = 1 - fractx;
            fracty2 = 1 - fracty;

            //Display the fraction abundances
            Label4.Text = fractx.ToString();
            Label5.Text = fractx2.ToString();
            Label6.Text = fracty.ToString();
            Label7.Text = fracty2.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Declaring experimental data
            double Rtotal; // The ratio total of m+1 divide by base total
            double Rtotal2;
            double mu; // The experimental value calculated from the abundance of a fragment divide by total abundance of fragment
            double alpha; // The ratio of base mass abundance to the total abundances of base mass fragments
            double fractx;
            double fracty;
            double fractz;
            double fractx2;
            double fracty2;
            double fractz2;

            // Accepting Values from users
            Rtotal = Convert.ToDouble(Rtotal1.Text);
            Rtotal2 = Convert.ToDouble(RTotal2.Text);
            mu = Convert.ToDouble(Expmu.Text);
            alpha = Convert.ToDouble(Alpha.Text);

            //Calculating x, x-1, y, y-1, z, z-1
            double sum = alpha + (Rtotal * mu);
            fractx = (alpha) / sum;
            double sum2 = -1 + (2 * fractx) + Rtotal * fractx;
            fracty = fractx / sum2;
            double sum3 = Math.Pow(alpha, 2) + (Math.Pow(alpha, 2) * Math.Pow(Rtotal2, 2)) - (Math.Pow(alpha, 2)
                * Math.Pow(Rtotal, 2)) + (alpha * Math.Pow(Rtotal, 2) * mu) - (Math.Pow(Rtotal, 2) * Math.Pow(mu, 2));
            fractz = (Math.Pow(alpha, 2)) / sum3;
            fractx2 = 1 - fractx; fracty2 = 1 - fracty; fractz2 = 1 - fractz;

            //Display the fraction abundances
            Label4.Text = fractx.ToString();
            Label5.Text = fractx2.ToString();
            Label6.Text = fracty.ToString();
            Label7.Text = fracty2.ToString();
            Label9.Text = fractz.ToString();
            Label10.Text = fractz2.ToString();
        }
    }
}
