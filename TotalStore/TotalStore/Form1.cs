using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalStore
{
    public partial class Form1 : Form
    {
        string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string Pname = txtName.Text;
            double Pqty = double.Parse(txtQTY.Text);
            double Pprice = double.Parse(txtPrice.Text);

            double total = Pqty * Pprice;
            txtTotalResult.Text = total.ToString();
        }

        private void txtShowEnter_Click(object sender, EventArgs e)
        {
            s = s + txtName.Text + '\t' + txtQTY.Text + '\t' + txtPrice.Text + '\t' + txtTotalResult.Text + '\n';
            MessageBox.Show(s);
        }

        private void txtQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
