using Bunifu.UI.WinForms.BunifuButton;
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
    }
}
