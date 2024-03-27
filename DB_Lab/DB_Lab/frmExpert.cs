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

            DataTable dtBorder = new DataTable();
            DataTable dtDistinctRes = new DataTable();
            DataTable dtDistinctPhone = new DataTable();
            
            dtBorder = h.myfunDt("SELECT MIN(salary), MAX(salary), MIN(hire_date), MAX(hire_date) FROM Expert");
            dtDistinctRes = h.myfunDt("SELECT DISTINCT researches FROM Expert");
            dtDistinctPhone = h.myfunDt("SELECT DISTINCT phone_number FROM Expert");

            // Записую межі у відповідні елементи керування:
            txtSalaryFrom.Text = dtBorder.Rows[0][0].ToString();
            txtSalaryTo.Text = dtBorder.Rows[0][1].ToString();
              
            dateHireDtFrom.Value = Convert.ToDateTime(dtBorder.Rows[0][2].ToString());
            dateHireDtTo.Value = Convert.ToDateTime(dtBorder.Rows[0][3].ToString());

            // Визначаю перелік можливих значень текстового поля:
            // cmbResearches.Items.Add("");
            for (int i = 0; i < dtDistinctRes.Rows.Count; i++)
            {
                cmbResearches.Items.Add(dtDistinctRes.Rows[i][0].ToString());
            }
            cmbResearches.DropDownStyle = ComboBoxStyle.DropDownList; // заборона редагування comboBox

            for (int i = 0; i < dtDistinctPhone.Rows.Count; i++)
            {
                cmbPhoneNum.Items.Add(dtDistinctPhone.Rows[i][0].ToString());
            }
            cmbPhoneNum.DropDownStyle = ComboBoxStyle.DropDownList;
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

    private void groupBox1_Paint(object sender, PaintEventArgs e)
    {
      Graphics gfx = e.Graphics;
      Pen p = new Pen(Color.AliceBlue, 1); // колір і товщина рамки

      gfx.DrawLine(p, 0, 5, 5, 5); // верхня горизонтальна лінія до Text

      gfx.DrawLine(p, 35, 5, e.ClipRectangle.Width - 2, 5); // верхня горизонтальна лінія після Text

      gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2); // верхня горизонтальна лінія до Text

      gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5,
                      e.ClipRectangle.Width - 2, 
                      e.ClipRectangle.Height - 2); // права вертикаль

      gfx.DrawLine(p, e.ClipRectangle.Width - 2,
                      e.ClipRectangle.Height - 2, 0,
                      e.ClipRectangle.Height - 2); // низ
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
      if (btnFilter.Checked)
      {
        this.Height = 450;
        groupBox1.Visible = true;
      }
      else
      {
        this.Height = 320;
        groupBox1.Visible = false;
      }
    }

        private void btnFilterOk_Click(object sender, EventArgs e)
        {
            string strFilter = "";
            strFilter += "expert_id > 0";

            // filer for expert_name
            if (txtExpertName.Text != "")
            {
                strFilter += " AND expert_name LIKE '" + txtExpertName.Text + "%'";
            }
            
            // filter for salary and hire_date
            if ((txtSalaryFrom.Text != "") && (txtSalaryTo.Text != ""))
            {
                strFilter +=
                    " AND (salary >= " + 
                    txtSalaryFrom.Text.ToString().Replace(',', '.') +
                    " AND salary <= " + 
                    txtSalaryTo.Text.ToString().Replace(",", ".") + ")";
            } 
            else if ((txtSalaryFrom.Text == "") && (txtSalaryTo.Text != ""))
            {
                strFilter +=
                    " AND (salary <= " + 
                    txtSalaryTo.Text.ToString().Replace(",", ".") + ")";
            }
            else if ((txtSalaryFrom.Text != "") && (txtSalaryTo.Text == ""))
            {
                strFilter +=
                    " AND (salary >= " +
                    txtSalaryFrom.Text.ToString().Replace(',', '.');
            }

            strFilter += " AND (hire_date >= '" + dateHireDtFrom.Value.ToString("yyyy-MM-dd") + 
                "'" + " AND hire_date <= '" + dateHireDtTo.Value.ToString("yyyy-MM-dd") + "')";

            // filter for unique values of Researches
            if (cmbResearches.Text != "")
            {
                strFilter += " AND (researches = '" + cmbResearches.Text + "')";
            }

            if (cmbPhoneNum.Text != "")
            {
                strFilter += " AND (phone_number = '" + cmbPhoneNum.Text + "')";
            }

            MessageBox.Show(strFilter);

            h.bs1.Filter = strFilter;
        }

        private void btnFilterCancel_Click(object sender, EventArgs e)
        {
            h.bs1.RemoveFilter();
        }
    }
}
