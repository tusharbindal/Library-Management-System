using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ReturnBook : Form
    {
        String bname;
        String bdate;
        Int64 rowid;
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEnterEnroll.Clear();

        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * from et_issuebook where std_enroll = '"+txtEnterEnroll.Text+"' and book_return_date IS NULL ");
            if(ds.Tables[0].Rows.Count != 0)
            {
                DGVReturn.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid id or no book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if(DGVReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(DGVReturn.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = DGVReturn.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = DGVReturn.Rows[e.RowIndex].Cells[8].Value.ToString();

            }
            txtBookName.Text = bname;
            dateTimePickerIssueDate.Text = bdate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            String error = Connection.SetData("Update et_issuebook Set book_return_date = '"+ dateTimePickerreturn.Text+"' where std_enroll = '"+ txtEnterEnroll.Text +"' and id = '"+rowid+"' ");
            if(error == "")
            {
                MessageBox.Show("Return Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReturnBook_Load(this, null);

            }
            else
            {
                MessageBox.Show("Error in Check" + error);
            }
        }

        private void txtEnterEnroll_TextChanged(object sender, EventArgs e)
        {
            if(txtEnterEnroll.Text == "")
            {
                panel2.Visible = false;
                DGVReturn.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnterEnroll.Clear();
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
