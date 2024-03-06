using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            cmbxAct.Items.Add("+");
            cmbxAct.Items.Add("-");
            cmbxAct.Items.Add("*");
            cmbxAct.Items.Add("/");

            cmbxAct.Text = "+";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (txtNum1.Text == "") num1 = 0; else num1 = double.Parse(txtNum1.Text);
            if (txtNum2.Text == "") num2 = 0; else num2 = Convert.ToDouble(txtNum2.Text);

            if (cmbxAct.SelectedIndex == 0)
                txtResult.Text = (num1 + num2).ToString();
            else if (cmbxAct.SelectedIndex == 1)
                txtResult.Text = (num1 - num2).ToString();
            else if (cmbxAct.SelectedIndex == 2)
                txtResult.Text = (num1 * num2).ToString();
            else if (cmbxAct.SelectedIndex == 3)
                txtResult.Text = (num1 / num2).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
