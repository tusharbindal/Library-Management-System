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
    public partial class CompleteBooksDetails : Form
    {
        public CompleteBooksDetails()
        {
            InitializeComponent();
        }

        private void CompleteBooksDetails_Load(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * from et_issuebook where book_return_date is null");
            dgvIssue.DataSource = ds.Tables[0];

            DataSet ds1 = Connection.GetData("Select * from et_issuebook where book_return_date is not null");
           dgvReturn.DataSource = ds1.Tables[0];
        }
    }
}
