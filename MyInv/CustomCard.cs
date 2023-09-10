using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
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
    public partial class CustomCard : UserControl
    {
        public string image, title, description, size;public int price;
        bool pressed=false;
        int j=0;
        public CustomCard()
        {
            InitializeComponent();
        }
        private void btn_MouseEnterAsync(object sender, EventArgs e)
        {
            if (j == 0)
            {
                if (!pressed)
                    guna2Panel1.BorderColor = Color.Beige;
                else { border.BorderColor = Color.Beige; border.BorderThickness = 1; }
                /*this.Size = new Size(Size.Width + 4, Size.Height + 4);
                this.Location = new Point(this.Location.X - 2, this.Location.Y - 2);*/
                j++;
                Task.Delay(2000).Wait();
                if (j == 0&&!pressed)
                    bunifuToolTip1.Show( "Press for more info",guna2PictureBox1);
            }
        }
        private void CustomCard_Load(object sender, EventArgs e)
        {
            description = desc.Text;
            bunifuToolTip1.SetToolTip(desc, description);
            bool childControlsOutsideBounds = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control.Bottom > flowLayoutPanel1.Height)
                {
                    childControlsOutsideBounds = true;
                    break;
                }
            }

            guna2VScrollBar1.Visible = childControlsOutsideBounds;
            if (childControlsOutsideBounds)
                guna2VScrollBar1.BindingContainer = flowLayoutPanel1;
            else guna2VScrollBar1.BindingContainer = border;
            foreach (Guna2TextBox txt in flowLayoutPanel1.Controls.OfType<Guna2TextBox>())
            {
                if (childControlsOutsideBounds)
                    txt.Width = 108;
                else txt.Width = 126;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (!pressed)
            {
                pressed = true;
                this.Width = 376;
                guna2Panel1.CustomizableEdges.TopRight=false;
                guna2Panel1.CustomizableEdges.BottomRight = false;
                guna2Panel1.BorderThickness = 0;
                guna2Panel1.BorderColor = Color.Transparent;
                guna2Panel2.Visible = true;
                border.BorderThickness = 1;
                border.BorderColor = Color.Black;

            }
        }

        private void bunifuIconButton1_Click_1(object sender, EventArgs e)
        {
            guna2Panel1.CustomizableEdges.TopRight = true;
            guna2Panel1.CustomizableEdges.BottomRight = true;
            guna2Panel1.CustomBorderThickness = new Padding(1, 1, 1, 1);
            guna2Panel2.Visible = false;
            border.BorderThickness = 0;
            guna2Panel1.BorderColor = Color.Black;
            border.BorderColor = Color.Transparent;
            guna2Panel1.BorderThickness = 1;
            this.Width = 243;
            pressed = false;
        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel1.Invalidate();
            
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (!(this.ClientRectangle.Contains(this.PointToClient(Cursor.Position))))
            {
                if (!pressed)
                    guna2Panel1.BorderColor = Color.Black;
                else { border.BorderColor = Color.Black; border.BorderThickness = 1; }
                    /*this.Size = new Size(Size.Width - 4, Size.Height - 4);
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
            btn_MouseEnterAsync(sender, e);
        }
    }
}
