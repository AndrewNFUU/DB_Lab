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
    public partial class frmExpert : Form
    {
        public frmExpert()
        {
            InitializeComponent();
        }

        private void TableExpert_Click(object sender, EventArgs e)
        {
            frmExpert f1 = new frmExpert();
            f1.ShowDialog();
        }

        private void frmExpert_Load(object sender, EventArgs e)
        {
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM Expert");
            dataGridView1.DataSource = h.bs1;
            bindingNavigator1.BindingSource = h.bs1;

            h.bs1.Sort = "expert_name ASC";

            DWGFormat();
        }

        void DWGFormat()
        {
            dataGridView1.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[0].HeaderText = "№";

            dataGridView1.Columns[1].Width = 130;

            dataGridView1.Columns[2].Width = 180;

            dataGridView1.Columns[3].Width = 100;

            dataGridView1.Columns[4].Width = 105;

            dataGridView1.Columns[5].Width = 65;

            dataGridView1.Columns[6].Width = 75;
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

        // basic method to find by entered text the whole row

        /*private void txtFind_TextChanged(object sender, EventArgs e)
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
        }*/

        // better method to find especially one cell instead of whole row
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

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
