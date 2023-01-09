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
    public partial class ViewStudent : Form
    {
        int id;
        Int64 rowid;
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void txtSearchEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnroll.Text != "")
            {
                lblviewStudent.Visible = false;
                Image image = Image.FromFile("D:/Align Project/Library Management System/img/search1.gif");
                pictureBox2.Image = image;

                DataSet ds = Connection.GetData("Select * from mst_student where enroll Like '" + txtSearchEnroll.Text + "%'");
                DGVStudent.DataSource = ds.Tables[0];
            }
            else
            {
                lblviewStudent.Visible = true;
                Image image = Image.FromFile("D:/Align Project/Library Management System/img/search1.gif");
                pictureBox2.Image = image;

                panel2.Visible = false;
                DataSet ds = Connection.GetData("Select * from mst_student");
                DGVStudent.DataSource = ds.Tables[0];
            }
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            DataSet ds = Connection.GetData("Select * from mst_student");
            DGVStudent.DataSource = ds.Tables[0];

        }

        private void DGVStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(DGVStudent.Rows[e.RowIndex].Cells[0].Value.ToString());
                {
                    //MessageBox.Show(DataGridViewBook.Rows[e.RowIndex].Cells.[0].Value.ToString());
                }
                panel2.Visible = true;
                DataSet ds = Connection.GetData("Select * from mst_student where id= " + id + "");

                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtEnroll.Text = ds.Tables[0].Rows[0][2].ToString();
                txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
                txtSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated. Confirm", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                String sname = txtName.Text;
                String enroll = txtEnroll.Text;
                String dep = txtDepartment.Text;
                String sem = txtSemester.Text;
                String contact = txtContact.Text;
                String semail = txtEmail.Text;

                String error = Connection.SetData("Update mst_student set sname = '" + sname + "', enroll = '" + enroll + "', dep = '" + dep + "', sem = '" + sem + "',contact = '" + contact + "', email = '" + semail + "' where id = " + rowid + " ");
                if (error == "")
                {
                    MessageBox.Show("Data Saved.", " Successful..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewStudent_Load(this, null);

                }
                else
                {
                    MessageBox.Show("Error in Saving : " + error);
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewStudent_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Data Will Be Deleted. Confirm", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                String error = Connection.SetData("Delete from mst_student where id= '" + rowid + "' ");
                if (error == "")
                {
                    MessageBox.Show("Student Record Deleated..");
                    ViewStudent_Load(this, null);

                }
                else
                {
                    MessageBox.Show("Error is Delete Messgae.." + error);
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data Will be Lost?", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
