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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitTool_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure You Want to Exit?","Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void addNewBookTool_Click(object sender, EventArgs e)
        {
            AddBooks frm = new AddBooks();
            frm.Show();
        }

        private void viewBookToolStrip_Click(object sender, EventArgs e)
        {
            ViewBook frm = new ViewBook();
            frm.Show();
        }

        private void addStudentToolStrip_Click(object sender, EventArgs e)
        {
            AddStudent frm = new AddStudent();
            frm.Show();
        }

        private void viewStudentInfoToolStrip_Click(object sender, EventArgs e)
        {
            ViewStudent frm = new ViewStudent();
            frm.Show();
        }

        private void issueBooksToolStrip_Click(object sender, EventArgs e)
        {
            IssueBook frm = new IssueBook();
            frm.Show();
        }

        private void returnBooksTool_Click(object sender, EventArgs e)
        {
            ReturnBook frm = new ReturnBook();
            frm.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBooksDetails frm = new CompleteBooksDetails();
            frm.Show();
        }
    }
}
