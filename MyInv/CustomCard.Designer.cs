namespace MyInv
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomCard));
            this.btn = new Guna.UI2.WinForms.Guna2Button();
            this.Title = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.Price = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.desc = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BorderRadius = 10;
            this.btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(140)))));
            this.btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(140)))));
            this.btn.Location = new System.Drawing.Point(3, 8);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(245, 325);
            this.btn.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.btn, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btn, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btn, "");
            this.btn.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // Title
            // 
            this.Title.AllowParentOverrides = false;
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Title.AutoEllipsis = false;
            this.Title.BackColor = System.Drawing.Color.Empty;
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.CursorType = System.Windows.Forms.Cursors.Default;
            this.Title.Font = new System.Drawing.Font("Arabic Typesetting", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Title.Location = new System.Drawing.Point(2, -3);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Title.Name = "Title";
            this.Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Title.Size = new System.Drawing.Size(83, 27);
            this.Title.TabIndex = 2;
            this.Title.Text = "Wall Clock";
            this.Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.Title, "");
            this.bunifuToolTip1.SetToolTipIcon(this.Title, null);
            this.bunifuToolTip1.SetToolTipTitle(this.Title, "");
            this.Title.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.Title.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // lblDescription
            // 
            this.lblDescription.AllowParentOverrides = false;
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescription.AutoEllipsis = false;
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDescription.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDescription.Font = new System.Drawing.Font("Arabic Typesetting", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDescription.Location = new System.Drawing.Point(1, 2);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(82, 23);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescription.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblDescription.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.bunifuToolTip1.SetToolTip(this.lblDescription, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblDescription, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblDescription, "");
            this.lblDescription.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.lblDescription.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 22;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.guna2PictureBox1);
            this.bunifuPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 8);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(245, 325);
            this.bunifuPanel1.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.bunifuPanel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPanel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPanel1, "");
            this.bunifuPanel1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.bunifuPanel1.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(241, 321);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.guna2PictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.guna2PictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.guna2PictureBox1, "");
            this.guna2PictureBox1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.guna2PictureBox1.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 333);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(245, 66);
            this.guna2Panel1.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.guna2Panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.guna2Panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.guna2Panel1, "");
            this.guna2Panel1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.guna2Panel1.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.Title);
            this.guna2Panel3.Controls.Add(this.Price);
            this.guna2Panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(245, 17);
            this.guna2Panel3.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.guna2Panel3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.guna2Panel3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.guna2Panel3, "");
            this.guna2Panel3.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.guna2Panel3.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // Price
            // 
            this.Price.AllowParentOverrides = false;
            this.Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Price.AutoEllipsis = false;
            this.Price.BackColor = System.Drawing.Color.Empty;
            this.Price.Cursor = System.Windows.Forms.Cursors.Default;
            this.Price.CursorType = System.Windows.Forms.Cursors.Default;
            this.Price.Font = new System.Drawing.Font("Arabic Typesetting", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Price.Location = new System.Drawing.Point(188, -3);
            this.Price.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Price.Name = "Price";
            this.Price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Price.Size = new System.Drawing.Size(54, 27);
            this.Price.TabIndex = 6;
            this.Price.Text = "50000$";
            this.Price.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Price.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.Price, "");
            this.bunifuToolTip1.SetToolTipIcon(this.Price, null);
            this.bunifuToolTip1.SetToolTipTitle(this.Price, "");
            this.Price.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.Price.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.desc);
            this.guna2Panel2.Controls.Add(this.lblDescription);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.bunifuLabel1);
            this.guna2Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 17);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(245, 49);
            this.guna2Panel2.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.guna2Panel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.guna2Panel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.guna2Panel2, "");
            this.guna2Panel2.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.guna2Panel2.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // desc
            // 
            this.desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desc.AutoRoundedCorners = true;
            this.desc.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.desc.BorderRadius = 9;
            this.desc.BorderThickness = 1;
            this.desc.Cursor = System.Windows.Forms.Cursors.Default;
            this.desc.DisabledState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.desc.DisabledState.CustomBorderColor = System.Drawing.Color.LightSteelBlue;
            this.desc.DisabledState.FillColor = System.Drawing.Color.SteelBlue;
            this.desc.DisabledState.ForeColor = System.Drawing.Color.Khaki;
            this.desc.FillColor = System.Drawing.Color.SteelBlue;
            this.desc.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.Color.Khaki;
            this.desc.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.desc.HoverState.CustomBorderColor = System.Drawing.Color.LightSteelBlue;
            this.desc.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.desc.HoverState.ForeColor = System.Drawing.Color.Khaki;
            this.desc.Location = new System.Drawing.Point(87, 3);
            this.desc.Name = "desc";
            this.desc.PressedColor = System.Drawing.Color.Empty;
            this.desc.PressedDepth = 0;
            this.desc.Size = new System.Drawing.Size(154, 21);
            this.desc.TabIndex = 8;
            this.desc.Text = "Antique wall clock made in china";
            this.desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.desc.TextOffset = new System.Drawing.Point(0, -1);
            this.bunifuToolTip1.SetToolTip(this.desc, "");
            this.bunifuToolTip1.SetToolTipIcon(this.desc, null);
            this.bunifuToolTip1.SetToolTipTitle(this.desc, "Description");
            this.desc.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.desc.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Button1.BorderRadius = 9;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.Khaki;
            this.guna2Button1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Goudy Old Style", 11.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Khaki;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Khaki;
            this.guna2Button1.Location = new System.Drawing.Point(37, 26);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Empty;
            this.guna2Button1.PressedDepth = 0;
            this.guna2Button1.Size = new System.Drawing.Size(106, 20);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "555*555 cm";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(0, -1);
            this.bunifuToolTip1.SetToolTip(this.guna2Button1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.guna2Button1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.guna2Button1, "");
            this.guna2Button1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.guna2Button1.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Arabic Typesetting", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(1, 25);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(31, 23);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "Size:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel1, "");
            this.bunifuLabel1.MouseEnter += new System.EventHandler(this.btn_MouseEnter_1);
            this.bunifuLabel1.MouseLeave += new System.EventHandler(this.btn_MouseLeave_1);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = true;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 500;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = "Description:";
            // 
            // CustomCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(140)))));
            this.BorderColor = System.Drawing.Color.Black;
            this.BorderRadius = 25;
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.guna2Panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CustomCard";
            this.Padding = new System.Windows.Forms.Padding(3, 8, 2, 1);
            this.Size = new System.Drawing.Size(250, 400);
            this.bunifuToolTip1.SetToolTip(this, "");
            this.bunifuToolTip1.SetToolTipIcon(this, null);
            this.bunifuToolTip1.SetToolTipTitle(this, "");
            this.Load += new System.EventHandler(this.CustomCard_Load);
            this.SizeChanged += new System.EventHandler(this.CustomCard_SizeChanged);
            this.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn;
        private Bunifu.UI.WinForms.BunifuLabel Title;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblDescription;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Bunifu.UI.WinForms.BunifuLabel Price;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2Button desc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
    }
}
