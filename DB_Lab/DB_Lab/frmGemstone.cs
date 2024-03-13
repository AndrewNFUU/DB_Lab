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
    public partial class frmGemstone : Form
    {
        public frmGemstone()
        {
            InitializeComponent();
        }

        private void TableGemstone_Click(object sender, EventArgs e)
        {
            frmGemstone f3 = new frmGemstone();
            f3.ShowDialog();
        }

        private void frmGemstone_Load(object sender, EventArgs e)
        {
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM Gemstone");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

            h.bs1.Sort = "source_of_origin ASC";

            DWGFormat();
        }

        void DWGFormat()
        {
            dataGridView1.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[0].HeaderText = "№";

            dataGridView1.Columns[1].Width = 70;

            dataGridView1.Columns[2].Width = 145;

            dataGridView1.Columns[3].Width = 75;

            dataGridView1.Columns[4].Width = 100;

            dataGridView1.Columns[5].Width = 65;

            dataGridView1.Columns[6].Width = 115;

            dataGridView1.Columns[7].Width = 110;
            dataGridView1.Columns[7].HeaderText = "market value";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (btnFind.Checked)
            {
                label1.Visible = true;
                txtFind.Visible = true;
                txtFind.Focus();
            }
            else
            {
                CancelFind();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;

                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtFind.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            btnFind.Checked = false;
            CancelFind();
        }

        private void CancelFind()
        {
            label1.Visible = false;
            txtFind.Visible = false;
            txtFind.Text = "";

            for (int i = 0; i < dataGridView1.RowCount; i++)
                dataGridView1.Rows[i].Selected = false;
        }
    }
}
