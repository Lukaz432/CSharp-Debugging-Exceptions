using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcExeptionError
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double subTotal = Convert.ToDouble(SubTotBox.Text);
            double tax = subTotal * 0.150;
            double grandTotal = subTotal + tax;
            SubTotBox.Text = subTotal.ToString("c");
            TaxBox.Text = tax.ToString("c");
            GranTotBox.Text = grandTotal.ToString("c");
        }

        private void GranTotBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            SubTotBox.Text = "";
            TaxBox.Text = "";
            GranTotBox.Text = "";
        }

        private void CalcErrBtn_Click(object sender, EventArgs e)
        {
            double subTotal = 0.0;
            double tax = 0.0;
            double grandTotal = 0.0;
            try
            {
                subTotal = Convert.ToDouble(SubTotBox.Text);
            } catch(Exception exc)
            {
                MessageBox.Show("It seems that " + exc.Message, "Oh shoot! There appears to be an error of the type: " + exc.GetType(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tax = subTotal * 0.150;
            grandTotal = subTotal + tax;
            TaxBox.Text = tax.ToString();
            GranTotBox.Text = grandTotal.ToString();
        }
    }
}
