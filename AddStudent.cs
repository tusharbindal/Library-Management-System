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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtEnroll.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEnroll.Text != "" && txtDepartment.Text != "" && txtSemester.Text != "" && txtContact.Text != "" && txtEmail.Text != "")
            {
                String name = txtName.Text;
                String enroll = txtEnroll.Text;
                String dep = txtDepartment.Text;
                String sem = txtSemester.Text;
                String contact = txtContact.Text;
                String email = txtEmail.Text;

                String error = Connection.SetData("Insert Into mst_student (sName, enroll, dep, sem, contact, email) Values " +
                            "('" + name + "', '" + enroll + "', '" + dep + "', '" + sem + "', '" + contact + "', '" + email + "' )");
                if (error == "")
                {
                    MessageBox.Show("Data Saved!", " Successful..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Error in Saving : " + error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}

