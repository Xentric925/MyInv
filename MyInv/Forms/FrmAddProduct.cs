﻿using System;
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
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filters to specify the type of files to show
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into a PictureBox control
                pictureBox.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
