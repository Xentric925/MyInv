namespace MyInv
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuPanel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.customMenu1 = new MyInv.customMenu();
            this.bunifuPanel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.Products = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2ImageButton();
            this.customCard1 = new MyInv.CustomCard();
            this.Receipts = new System.Windows.Forms.TabPage();
            this.Invoices = new System.Windows.Forms.TabPage();
            this.Suppliers = new System.Windows.Forms.TabPage();
            this.Sales = new System.Windows.Forms.TabPage();
            this.Payments = new System.Windows.Forms.TabPage();
            this.Installments = new System.Windows.Forms.TabPage();
            this.Reminders = new System.Windows.Forms.TabPage();
            this.bunifuImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bunifuPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuFormControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.Products.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Reminders.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.customMenu1);
            this.bunifuPanel2.Controls.Add(this.bunifuPanel3);
            this.bunifuPanel2.Location = new System.Drawing.Point(1, 41);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.Size = new System.Drawing.Size(1198, 558);
            this.bunifuPanel2.TabIndex = 2;
            // 
            // customMenu1
            // 
            this.customMenu1.BackColor = System.Drawing.Color.Transparent;
            this.customMenu1.BorderColor = System.Drawing.Color.Transparent;
            this.customMenu1.BorderRadius = 5;
            this.customMenu1.BorderThickness = 1;
            this.customMenu1.Cursor = System.Windows.Forms.Cursors.Default;
            this.customMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.customMenu1.Location = new System.Drawing.Point(0, 0);
            this.customMenu1.Name = "customMenu1";
            this.customMenu1.Size = new System.Drawing.Size(310, 558);
            this.customMenu1.TabIndex = 4;
            this.customMenu1.SelectedIndexChanged += new System.EventHandler(this.customMenu1_SelectedIndexChanged);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.guna2TabControl1);
            this.bunifuPanel3.Location = new System.Drawing.Point(310, 0);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.Size = new System.Drawing.Size(888, 558);
            this.bunifuPanel3.TabIndex = 3;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.Products);
            this.guna2TabControl1.Controls.Add(this.Receipts);
            this.guna2TabControl1.Controls.Add(this.Invoices);
            this.guna2TabControl1.Controls.Add(this.Suppliers);
            this.guna2TabControl1.Controls.Add(this.Sales);
            this.guna2TabControl1.Controls.Add(this.Payments);
            this.guna2TabControl1.Controls.Add(this.Installments);
            this.guna2TabControl1.Controls.Add(this.Reminders);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(888, 558);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabStop = false;
            this.guna2TabControl1.SelectedIndexChanged += new System.EventHandler(this.guna2TabControl1_SelectedIndexChanged);
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Products.Controls.Add(this.flowLayoutPanel1);
            this.Products.ForeColor = System.Drawing.Color.Beige;
            this.Products.Location = new System.Drawing.Point(184, 4);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(700, 550);
            this.Products.TabIndex = 0;
            this.Products.Text = "tabPage1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnAddProduct);
            this.flowLayoutPanel1.Controls.Add(this.customCard1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(694, 544);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddProduct.ImageRotate = 0F;
            this.btnAddProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(50, 50);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // customCard1
            // 
            this.customCard1.AutoScroll = true;
            this.customCard1.BackColor = System.Drawing.Color.Transparent;
            this.customCard1.Cursor = System.Windows.Forms.Cursors.Default;
            this.customCard1.Location = new System.Drawing.Point(59, 3);
            this.customCard1.Name = "customCard1";
            this.customCard1.Size = new System.Drawing.Size(243, 346);
            this.customCard1.TabIndex = 7;
            // 
            // Receipts
            // 
            this.Receipts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Receipts.ForeColor = System.Drawing.Color.Beige;
            this.Receipts.Location = new System.Drawing.Point(184, 4);
            this.Receipts.Name = "Receipts";
            this.Receipts.Padding = new System.Windows.Forms.Padding(3);
            this.Receipts.Size = new System.Drawing.Size(700, 550);
            this.Receipts.TabIndex = 1;
            this.Receipts.Text = "tabPage2";
            // 
            // Invoices
            // 
            this.Invoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Invoices.ForeColor = System.Drawing.Color.Beige;
            this.Invoices.Location = new System.Drawing.Point(184, 4);
            this.Invoices.Name = "Invoices";
            this.Invoices.Padding = new System.Windows.Forms.Padding(3);
            this.Invoices.Size = new System.Drawing.Size(700, 550);
            this.Invoices.TabIndex = 2;
            this.Invoices.Text = "tabPage3";
            // 
            // Suppliers
            // 
            this.Suppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Suppliers.ForeColor = System.Drawing.Color.Beige;
            this.Suppliers.Location = new System.Drawing.Point(184, 4);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(700, 550);
            this.Suppliers.TabIndex = 3;
            this.Suppliers.Text = "tabPage1";
            // 
            // Sales
            // 
            this.Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Sales.ForeColor = System.Drawing.Color.Beige;
            this.Sales.Location = new System.Drawing.Point(184, 4);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(700, 550);
            this.Sales.TabIndex = 4;
            this.Sales.Text = "tabPage1";
            // 
            // Payments
            // 
            this.Payments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Payments.ForeColor = System.Drawing.Color.Beige;
            this.Payments.Location = new System.Drawing.Point(184, 4);
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(700, 550);
            this.Payments.TabIndex = 5;
            this.Payments.Text = "tabPage1";
            this.Payments.Click += new System.EventHandler(this.Payments_Click);
            // 
            // Installments
            // 
            this.Installments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Installments.ForeColor = System.Drawing.Color.Beige;
            this.Installments.Location = new System.Drawing.Point(184, 4);
            this.Installments.Name = "Installments";
            this.Installments.Size = new System.Drawing.Size(700, 550);
            this.Installments.TabIndex = 6;
            this.Installments.Text = "tabPage1";
            // 
            // Reminders
            // 
            this.Reminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Reminders.Controls.Add(this.bunifuImageButton1);
            this.Reminders.ForeColor = System.Drawing.Color.Beige;
            this.Reminders.Location = new System.Drawing.Point(5, 4);
            this.Reminders.Name = "Reminders";
            this.Reminders.Size = new System.Drawing.Size(879, 550);
            this.Reminders.TabIndex = 7;
            this.Reminders.Text = "tabPage1";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.ImageRotate = 0F;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.Location = new System.Drawing.Point(414, 250);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.LightBlue;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuFormControlBox1);
            this.bunifuPanel1.Location = new System.Drawing.Point(4, 4);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.Size = new System.Drawing.Size(1198, 35);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // bunifuFormControlBox1
            // 
            this.bunifuFormControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFormControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.bunifuFormControlBox1.IconColor = System.Drawing.Color.White;
            this.bunifuFormControlBox1.Location = new System.Drawing.Point(1060, -2);
            this.bunifuFormControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuFormControlBox1.Name = "bunifuFormControlBox1";
            this.bunifuFormControlBox1.Size = new System.Drawing.Size(137, 41);
            this.bunifuFormControlBox1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyInv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.Products.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Reminders.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel bunifuPanel1;
        private Guna.UI2.WinForms.Guna2Panel bunifuPanel2;
        private Guna.UI2.WinForms.Guna2Panel bunifuPanel3;
        private customMenu customMenu1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabPage Receipts;
        private System.Windows.Forms.TabPage Invoices;
        private System.Windows.Forms.TabPage Suppliers;
        private System.Windows.Forms.TabPage Sales;
        private System.Windows.Forms.TabPage Payments;
        private System.Windows.Forms.TabPage Installments;
        private System.Windows.Forms.TabPage Reminders;
        private Guna.UI2.WinForms.Guna2ControlBox bunifuFormControlBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton  btnAddProduct;
        private Guna.UI2.WinForms.Guna2ImageButton bunifuImageButton1;
        private CustomCard customCard1;
    }
}

