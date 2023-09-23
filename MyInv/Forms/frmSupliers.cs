using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace MyInv
{
    public partial class frmSupliers : Form
    {
        public frmSupliers()
        {
            InitializeComponent();
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void addNewSupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set up the drawing area and font
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);

            float yPosition = 0; // Vertical position to start drawing

            // Iterate through ListView items and draw them
            foreach (ListViewItem item in listView1.Items)
            {
                // Draw each item's text
                graphics.DrawString(item.Text, font, Brushes.Black, new PointF(10, yPosition));

                // Update vertical position for the next item
                yPosition += font.Height;
            }

            // Check if there are more items to print on the next page
            if (yPosition < e.MarginBounds.Height)
                e.HasMorePages = false;
            else
                e.HasMorePages = true;
        }
        private void printOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
