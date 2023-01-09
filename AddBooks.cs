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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                String bname = txtName.Text;
                String bAuthor = txtAuthor.Text;
                String publication = txtPublication.Text;
                String pdate = dateTimePickerPurchase.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                String error = Connection.SetData("Insert Into mst_newbook (bName, bAuthor, bPubl, bDate, bPrice, bQuan) Values " +
                    "('" + bname + "', '" + bAuthor + "', '" + publication + "', '" + pdate + "', " + price + ", " + quan + " )");
                if (error == "")
                {
                    MessageBox.Show("Data Saved.", " Successful..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Error in Saving : " + error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed ","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtAuthor.Clear();
            txtPublication.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
          

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will Delete your UnSaved Data.", "Are you Sure)",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
                

                 
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }
    }
}

