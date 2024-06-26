﻿namespace MyInv
{
    partial class CustomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomCard));
            this.bunifuToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ImageContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bunifuLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.desc = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bunifuTextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bunifuTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuPanel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuIconButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.border = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.ImageContextMenuStrip.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.border.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.AllowLinksHandling = true;
            this.bunifuToolTip1.AutomaticDelay = 1000;
            this.bunifuToolTip1.AutoPopDelay = 2500;
            this.bunifuToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(137)))), ((int)(((byte)(77)))));
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.DimGray;
            this.bunifuToolTip1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuToolTip1.InitialDelay = 1000;
            this.bunifuToolTip1.MaximumSize = new System.Drawing.Size(130, 0);
            this.bunifuToolTip1.ReshowDelay = 500;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.ContextMenuStrip = this.ImageContextMenuStrip;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(191, 252);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.guna2PictureBox1, "Press for more info");
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            this.guna2PictureBox1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.guna2PictureBox1.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // ImageContextMenuStrip
            // 
            this.ImageContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ImageContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.copyImageToolStripMenuItem});
            this.ImageContextMenuStrip.Name = "guna2ContextMenuStrip1";
            this.ImageContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ImageContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ImageContextMenuStrip.RenderStyle.ColorTable = null;
            this.ImageContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.ImageContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ImageContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ImageContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ImageContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ImageContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ImageContextMenuStrip.Size = new System.Drawing.Size(139, 48);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveImageToolStripMenuItem.Image = global::MyInv.Properties.Resources.Save;
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            // 
            // copyImageToolStripMenuItem
            // 
            this.copyImageToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.copyImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyImageToolStripMenuItem.Image")));
            this.copyImageToolStripMenuItem.Name = "copyImageToolStripMenuItem";
            this.copyImageToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.copyImageToolStripMenuItem.Text = "Copy Image";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.bunifuPanel1);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(55)))));
            this.guna2Panel1.Location = new System.Drawing.Point(1, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel1.Size = new System.Drawing.Size(201, 286);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.guna2Panel1.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderRadius = 10;
            this.bunifuPanel1.Controls.Add(this.btnNext);
            this.bunifuPanel1.Controls.Add(this.btnPrev);
            this.bunifuPanel1.Controls.Add(this.guna2PictureBox1);
            this.bunifuPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))), ((int)(((byte)(125)))));
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 4);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.bunifuPanel1.Size = new System.Drawing.Size(195, 256);
            this.bunifuPanel1.TabIndex = 12;
            this.bunifuPanel1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))), ((int)(((byte)(77)))));
            this.btnNext.BorderRadius = 6;
            this.btnNext.BorderThickness = 2;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))), ((int)(((byte)(77)))));
            this.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNext.Image = global::MyInv.Properties.Resources.Right;
            this.btnNext.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnNext.ImageSize = new System.Drawing.Size(26, 26);
            this.btnNext.Location = new System.Drawing.Point(163, 113);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedColor = System.Drawing.Color.Gray;
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 7;
            this.btnNext.UseTransparentBackground = true;
            this.btnNext.Click += new System.EventHandler(this.guna2Button1_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.btnNext.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))), ((int)(((byte)(77)))));
            this.btnPrev.BorderRadius = 6;
            this.btnPrev.BorderThickness = 2;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))), ((int)(((byte)(77)))));
            this.btnPrev.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPrev.Image = global::MyInv.Properties.Resources.Left;
            this.btnPrev.ImageSize = new System.Drawing.Size(26, 26);
            this.btnPrev.Location = new System.Drawing.Point(4, 113);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.PressedColor = System.Drawing.Color.Gray;
            this.btnPrev.Size = new System.Drawing.Size(30, 30);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.UseTransparentBackground = true;
            this.btnPrev.Visible = false;
            this.btnPrev.Click += new System.EventHandler(this.guna2Button2_Click);
            this.btnPrev.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.btnPrev.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.Controls.Add(this.bunifuLabel1);
            this.guna2Panel3.Controls.Add(this.bunifuLabel2);
            this.guna2Panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(3, 260);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(195, 22);
            this.guna2Panel3.TabIndex = 13;
            this.guna2Panel3.UseTransparentBackground = true;
            this.guna2Panel3.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            this.guna2Panel3.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.guna2Panel3.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuLabel1.Location = new System.Drawing.Point(139, 0);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(56, 22);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "500000$";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.bunifuLabel1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            this.bunifuLabel1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuLabel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(68, 22);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "Wall Clock";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.bunifuLabel2.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            this.bunifuLabel2.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.guna2VScrollBar1);
            this.guna2Panel2.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel2.Controls.Add(this.bunifuPanel2);
            this.guna2Panel2.CustomizableEdges.BottomLeft = false;
            this.guna2Panel2.CustomizableEdges.TopLeft = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(55)))));
            this.guna2Panel2.Location = new System.Drawing.Point(202, 1);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(1, 3, 4, 4);
            this.guna2Panel2.Size = new System.Drawing.Size(110, 286);
            this.guna2Panel2.TabIndex = 12;
            this.guna2Panel2.Visible = false;
            this.guna2Panel2.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BindingContainer = this.flowLayoutPanel1;
            this.guna2VScrollBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))), ((int)(((byte)(125)))));
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 234;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(88, 31);
            this.guna2VScrollBar1.Maximum = 287;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 251);
            this.guna2VScrollBar1.SmallChange = 5;
            this.guna2VScrollBar1.TabIndex = 13;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(100)))), ((int)(((byte)(89)))));
            this.guna2VScrollBar1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.bunifuLabel3);
            this.flowLayoutPanel1.Controls.Add(this.desc);
            this.flowLayoutPanel1.Controls.Add(this.bunifuLabel4);
            this.flowLayoutPanel1.Controls.Add(this.bunifuTextBox2);
            this.flowLayoutPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.flowLayoutPanel1.Controls.Add(this.bunifuTextBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 251);
            this.flowLayoutPanel1.TabIndex = 20;
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
            this.flowLayoutPanel1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuLabel3.Location = new System.Drawing.Point(3, 3);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(77, 17);
            this.bunifuLabel3.TabIndex = 15;
            this.bunifuLabel3.Text = "Description:";
            this.bunifuLabel3.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // desc
            // 
            this.desc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.desc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(29)))));
            this.desc.BorderRadius = 9;
            this.desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.desc.DefaultText = "Antique Wall Clock Made in Europe";
            this.desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.desc.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.desc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(140)))), ((int)(((byte)(125)))));
            this.desc.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.Color.Empty;
            this.desc.HoverState.BorderColor = System.Drawing.Color.Beige;
            this.desc.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.desc.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.desc.Location = new System.Drawing.Point(3, 26);
            this.desc.MinimumSize = new System.Drawing.Size(1, 1);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.PasswordChar = '\0';
            this.desc.PlaceholderForeColor = System.Drawing.Color.Black;
            this.desc.PlaceholderText = "";
            this.desc.ReadOnly = true;
            this.desc.SelectedText = "";
            this.desc.Size = new System.Drawing.Size(94, 76);
            this.desc.TabIndex = 31;
            this.desc.TextOffset = new System.Drawing.Point(0, -1);
            this.desc.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuLabel4.Location = new System.Drawing.Point(3, 108);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(50, 17);
            this.bunifuLabel4.TabIndex = 20;
            this.bunifuLabel4.Text = "Capital:";
            this.bunifuLabel4.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // bunifuTextBox2
            // 
            this.bunifuTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(29)))));
            this.bunifuTextBox2.BorderRadius = 9;
            this.bunifuTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox2.DefaultText = "500$";
            this.bunifuTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.bunifuTextBox2.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.bunifuTextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(140)))), ((int)(((byte)(125)))));
            this.bunifuTextBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox2.ForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox2.HoverState.BorderColor = System.Drawing.Color.Beige;
            this.bunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox2.Location = new System.Drawing.Point(3, 131);
            this.bunifuTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox2.Multiline = true;
            this.bunifuTextBox2.Name = "bunifuTextBox2";
            this.bunifuTextBox2.PasswordChar = '\0';
            this.bunifuTextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
            this.bunifuTextBox2.PlaceholderText = "";
            this.bunifuTextBox2.ReadOnly = true;
            this.bunifuTextBox2.SelectedText = "";
            this.bunifuTextBox2.Size = new System.Drawing.Size(94, 32);
            this.bunifuTextBox2.TabIndex = 21;
            this.bunifuTextBox2.TextOffset = new System.Drawing.Point(0, -1);
            this.bunifuTextBox2.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 169);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(31, 17);
            this.guna2HtmlLabel1.TabIndex = 32;
            this.guna2HtmlLabel1.Text = "Size:";
            this.guna2HtmlLabel1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(29)))));
            this.bunifuTextBox1.BorderRadius = 9;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultText = "150*50cm";
            this.bunifuTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.bunifuTextBox1.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.bunifuTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(140)))), ((int)(((byte)(125)))));
            this.bunifuTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.ForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.HoverState.BorderColor = System.Drawing.Color.Beige;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Location = new System.Drawing.Point(3, 192);
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Multiline = true;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.bunifuTextBox1.PlaceholderText = "";
            this.bunifuTextBox1.ReadOnly = true;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.Size = new System.Drawing.Size(94, 32);
            this.bunifuTextBox1.TabIndex = 19;
            this.bunifuTextBox1.TextOffset = new System.Drawing.Point(0, -1);
            this.bunifuTextBox1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.Controls.Add(this.bunifuIconButton1);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(1, 3);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.Size = new System.Drawing.Size(105, 28);
            this.bunifuPanel2.TabIndex = 21;
            this.bunifuPanel2.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // bunifuIconButton1
            // 
            this.bunifuIconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuIconButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuIconButton1.HoverState.Image = global::MyInv.Properties.Resources.CloseIcon;
            this.bunifuIconButton1.HoverState.ImageOffset = new System.Drawing.Point(-1, -1);
            this.bunifuIconButton1.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.bunifuIconButton1.Image = global::MyInv.Properties.Resources.CloseIcon;
            this.bunifuIconButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.bunifuIconButton1.ImageRotate = 0F;
            this.bunifuIconButton1.ImageSize = new System.Drawing.Size(22, 22);
            this.bunifuIconButton1.Location = new System.Drawing.Point(83, -1);
            this.bunifuIconButton1.Name = "bunifuIconButton1";
            this.bunifuIconButton1.PressedState.ImageOffset = new System.Drawing.Point(-2, -2);
            this.bunifuIconButton1.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.bunifuIconButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuIconButton1.TabIndex = 17;
            this.bunifuIconButton1.Click += new System.EventHandler(this.bunifuIconButton1_Click_1);
            this.bunifuIconButton1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            // 
            // border
            // 
            this.border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(91)))), ((int)(((byte)(93)))));
            this.border.BorderRadius = 10;
            this.border.BorderThickness = 1;
            this.border.Controls.Add(this.guna2Panel1);
            this.border.Controls.Add(this.guna2Panel2);
            this.border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.border.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(91)))), ((int)(((byte)(93)))));
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Padding = new System.Windows.Forms.Padding(1);
            this.border.Size = new System.Drawing.Size(313, 288);
            this.border.TabIndex = 13;
            this.border.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.border.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // CustomCard
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.border);
            this.Name = "CustomCard";
            this.Size = new System.Drawing.Size(313, 288);
            this.Load += new System.EventHandler(this.CustomCard_Load);
            this.MouseEnter += new System.EventHandler(this.btn_MouseEnterAsync);
            this.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ImageContextMenuStrip.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlToolTip bunifuToolTip1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel bunifuPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel bunifuLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel border;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton bunifuIconButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel bunifuLabel3;
        private Guna.UI2.WinForms.Guna2TextBox bunifuTextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel bunifuLabel4;
        private Guna.UI2.WinForms.Guna2TextBox bunifuTextBox2;
        private Guna.UI2.WinForms.Guna2Panel bunifuPanel2;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2TextBox desc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ImageContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyImageToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
    }
}
