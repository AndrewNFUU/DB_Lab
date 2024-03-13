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
    public partial class frmExploration : Form
    {
        public frmExploration()
        {
            InitializeComponent();
        }

        private void TableExploration_Click(object sender, EventArgs e)
        {
            frmExploration f2 = new frmExploration();
            f2.ShowDialog();
        }

        private void frmExploration_Load(object sender, EventArgs e)
        {
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM Exploration");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

            h.bs1.Sort = dataGridView1.Columns[4].Name;

            DWGFormat();
        }

        void DWGFormat()
        {
            dataGridView1.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            dataGridView1.Columns[0].Width = 100;

            dataGridView1.Columns[1].Width = 75;
            
            dataGridView1.Columns[2].Width = 60;
            
            dataGridView1.Columns[3].Width = 90;
            
            dataGridView1.Columns[4].Width = 95;
            dataGridView1.Columns[4].HeaderText = "exploration date";

            dataGridView1.Columns[5].Width = 85;
            dataGridView1.Columns[5].HeaderText = "exploration time";

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
            // Deselect all cells before starting a new search
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Selected = false;
                }
            }

            // Itarate through each cell to find the specified text
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtFind.Text))
                        {
                            // Set the selection for the found cell
                            dataGridView1.Rows[i].Cells[j].Selected = true;
                            // Exit the method after finding the first cell with the specified text
                            return;
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
