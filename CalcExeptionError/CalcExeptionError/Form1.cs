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

        private void CalcErrIntBtn_Click(object sender, EventArgs e)
        {
            int subTotal = 0;
            double tax = 0.0;
            double grandTotal = 0.0;
            try
            {
                subTotal = Convert.ToInt32(SubTotBox.Text);
            } catch(OverflowException exc)
            {
                MessageBox.Show("Try a smaller number. " + exc.Message, "The number input is either too small or too large for " + exc.GetType(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch(Exception exc)
            {
                MessageBox.Show("It seems that " + exc.Message, "Oh shoot! There appears to be an error of the type: " + exc.GetType(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmptErrBtn_Click(object sender, EventArgs e)
        {
            double subTotal = 0;
            double tax = 0.0;
            double grandTotal = 0.0;
            string inputText = null;
            string message = "Till next time!";
            try
            {
                subTotal = Convert.ToDouble(SubTotBox.Text);
                inputText = SubTotBox.Text;
            }
            catch(Exception exc)
            {
                if(inputText.Length == 0)
                {
                    MessageBox.Show("Field can not be empty! You must input data in the Sub Total field", "Error.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                MessageBox.Show("Thank you for using our calculator v1.1 demo!", "See you soon!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
