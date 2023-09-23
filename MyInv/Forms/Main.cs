using FontAwesome.Sharp;
using Guna.UI2.WinForms;
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
        int i = 0;int nbPressedSort=0;
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
            /*this.Invalidate();*/

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
            if (this.Height < 630 && bunifuPanel3.CustomizableEdges.BottomLeft == true)
            {
                bunifuPanel3.CustomizableEdges.BottomLeft = false;
            }
            else
            {
                if (this.Height < 630 && bunifuPanel3.CustomizableEdges.BottomLeft == false)
                {
                    bunifuPanel3.CustomizableEdges.BottomLeft = true;
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            guna2ContextMenuStrip1.Show(iconButton1.PointToScreen(new Point(0, iconButton1.Height)));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                sortPanel.Visible = true;
                i++;
            }
            else
            {
                sortPanel.Visible = false;
                i--;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            if (btn.Checked)
            {
                sortPanel.Controls.SetChildIndex(btn, 0);
                nbPressedSort++;
            }else sortPanel.Controls.SetChildIndex(btn, int.Parse(btn.Tag.ToString())+--nbPressedSort);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            updateFilter(txtSearch.Text);
        }

        private void updateFilter()
        {

        }

        private void updateFilter(string text)
        {

        }

        private void iconMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            updateFilter();
        }
    }
}
