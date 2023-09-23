using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace MyInv
{
    public partial class customMenu : UserControl
    {
        private int selectedIndex = 0;
        public event EventHandler SelectedIndexChanged;
        public int SelectedIndex { get { return selectedIndex; } }
        public customMenu()
        {
            InitializeComponent();
        }
        protected virtual void OnSelectedIndexChanged(EventArgs e)
        {
            SelectedIndexChanged?.Invoke(this, e);
        }
        public void UpdateSelectedIndex(int newIndex)
        {
            if (selectedIndex != newIndex-1)
            {
                selectedIndex = newIndex-1;
                OnSelectedIndexChanged(EventArgs.Empty);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {   
            Guna2Button btn = sender as Guna2Button;
            int.TryParse(btn.Tag.ToString(),out int i);
            foreach(var x in bunifuPanel1.Controls)
            {
                if(x is Guna2PictureBox pic)
                {
                    if (pic.Tag == btn.Tag)
                        pic.Visible = true;
                    else pic.Visible = false;
                }
            }
            UpdateSelectedIndex(i);
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        { 
            Guna2Button btn = sender as Guna2Button;
            if(!btn.Checked)
                btn.ImageSize = new Size(50, 50);
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            if(!btn.Checked)
                btn.ImageSize = new Size(45,45);
        }
    }
}
