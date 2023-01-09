
namespace Library_Management_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookTool = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentInfoToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksTool = new System.Windows.Forms.ToolStripMenuItem();
            this.completeBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.issueBooksToolStrip,
            this.returnBooksTool,
            this.completeBookDetailsToolStripMenuItem,
            this.exitTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1475, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookTool,
            this.viewBookToolStrip});
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(127, 54);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBookTool
            // 
            this.addNewBookTool.Image = ((System.Drawing.Image)(resources.GetObject("addNewBookTool.Image")));
            this.addNewBookTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewBookTool.Name = "addNewBookTool";
            this.addNewBookTool.Size = new System.Drawing.Size(260, 60);
            this.addNewBookTool.Text = "Add New Book";
            this.addNewBookTool.Click += new System.EventHandler(this.addNewBookTool_Click);
            // 
            // viewBookToolStrip
            // 
            this.viewBookToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("viewBookToolStrip.Image")));
            this.viewBookToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBookToolStrip.Name = "viewBookToolStrip";
            this.viewBookToolStrip.Size = new System.Drawing.Size(260, 60);
            this.viewBookToolStrip.Text = "View Book";
            this.viewBookToolStrip.Click += new System.EventHandler(this.viewBookToolStrip_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStrip,
            this.viewStudentInfoToolStrip});
            this.studentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentToolStripMenuItem.Image")));
            this.studentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(139, 54);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStrip
            // 
            this.addStudentToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("addStudentToolStrip.Image")));
            this.addStudentToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStudentToolStrip.Name = "addStudentToolStrip";
            this.addStudentToolStrip.Size = new System.Drawing.Size(283, 60);
            this.addStudentToolStrip.Text = "Add Student";
            this.addStudentToolStrip.Click += new System.EventHandler(this.addStudentToolStrip_Click);
            // 
            // viewStudentInfoToolStrip
            // 
            this.viewStudentInfoToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("viewStudentInfoToolStrip.Image")));
            this.viewStudentInfoToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewStudentInfoToolStrip.Name = "viewStudentInfoToolStrip";
            this.viewStudentInfoToolStrip.Size = new System.Drawing.Size(283, 60);
            this.viewStudentInfoToolStrip.Text = "View Student InFo";
            this.viewStudentInfoToolStrip.Click += new System.EventHandler(this.viewStudentInfoToolStrip_Click);
            // 
            // issueBooksToolStrip
            // 
            this.issueBooksToolStrip.BackColor = System.Drawing.Color.OldLace;
            this.issueBooksToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("issueBooksToolStrip.Image")));
            this.issueBooksToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueBooksToolStrip.Name = "issueBooksToolStrip";
            this.issueBooksToolStrip.Size = new System.Drawing.Size(172, 54);
            this.issueBooksToolStrip.Text = "Issue Books";
            this.issueBooksToolStrip.Click += new System.EventHandler(this.issueBooksToolStrip_Click);
            // 
            // returnBooksTool
            // 
            this.returnBooksTool.Image = ((System.Drawing.Image)(resources.GetObject("returnBooksTool.Image")));
            this.returnBooksTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnBooksTool.Name = "returnBooksTool";
            this.returnBooksTool.Size = new System.Drawing.Size(183, 54);
            this.returnBooksTool.Text = "Return Books";
            this.returnBooksTool.Click += new System.EventHandler(this.returnBooksTool_Click);
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            this.completeBookDetailsToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.completeBookDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("completeBookDetailsToolStripMenuItem.Image")));
            this.completeBookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            this.completeBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(83, 54);
            this.completeBookDetailsToolStripMenuItem.Text = " ";
            this.completeBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.completeBookDetailsToolStripMenuItem_Click);
            // 
            // exitTool
            // 
            this.exitTool.BackColor = System.Drawing.Color.OldLace;
            this.exitTool.Image = ((System.Drawing.Image)(resources.GetObject("exitTool.Image")));
            this.exitTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitTool.Name = "exitTool";
            this.exitTool.Size = new System.Drawing.Size(105, 54);
            this.exitTool.Text = "Exit";
            this.exitTool.Click += new System.EventHandler(this.exitTool_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1475, 757);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookTool;
        private System.Windows.Forms.ToolStripMenuItem viewBookToolStrip;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStrip;
        private System.Windows.Forms.ToolStripMenuItem viewStudentInfoToolStrip;
        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStrip;
        private System.Windows.Forms.ToolStripMenuItem returnBooksTool;
        private System.Windows.Forms.ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTool;
    }
}