using MyInv.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInv
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }


        private void customMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedIndex = customMenu1.SelectedIndex;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }

       

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            // Instantiate the new form
            FrmAddProduct frm = new FrmAddProduct();
            frm.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmReminders frm = new frmReminders();
            frm.Show();
        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel1.Invalidate();
        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            guna2Panel1.Cursor = Cursors.SizeAll;
        }

        private void guna2Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            guna2Panel1.Cursor = Cursors.Default;
        }

        private void Main_MouseLeave(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                Cursor = Cursors.Default;
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            foreach (Control c in this.Controls)
            {
                c.Invalidate();
            }
        }
    }
}
