using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInv
{
    public partial class CustomCard : BunifuUserControl
    {
        public string image, title, description, size;public int price;
        int j=0;
        public CustomCard()
        {
            InitializeComponent();
        }
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            if (j == 0)
            {
                this.BorderColor = Color.Beige;/*
                this.Size = new Size(Size.Width + 4, Size.Height + 4);
                this.Location = new Point(this.Location.X - 2, this.Location.Y - 2);*/
                j++;
            }
        }
        private void updateDesc()
        {
            string text = desc.Text; // Replace with the actual component's Text property
            Font font = desc.Font; // Replace with the actual component's Font property

            int maxWidth = 120; // Maximum width in pixels you want to check

            Size textSize = TextRenderer.MeasureText(text, font);
            /*MessageBox.Show(textSize.ToString());*/

            if (textSize.Width >= maxWidth)
            {
                desc.Text = desc.Text.Split(' ')[0]+ " "+ desc.Text.Split(' ')[1]+" "+ desc.Text.Split(' ')[2] + "...";
            }
        }
        private void CustomCard_Load(object sender, EventArgs e)
        {
            description = desc.Text;
            bunifuToolTip1.SetToolTip(desc, description);
            updateDesc();
        }

        private void CustomCard_SizeChanged(object sender, EventArgs e)
        {
            updateDesc();
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (!(this.ClientRectangle.Contains(this.PointToClient(Cursor.Position))))
            {
                this.BorderColor = Color.Black;/*
                this.Size = new Size(Size.Width - 4, Size.Height - 4);
                this.Location = new Point(this.Location.X + 2, this.Location.Y + 2);*/
                j--;
            }
        }
        private void btn_MouseLeave_1(object sender, EventArgs e)
        {
            btn_MouseLeave(sender, e);
        }

        private void btn_MouseEnter_1(object sender, EventArgs e)
        {
            btn_MouseEnter(sender, e);
        }
    }
}
