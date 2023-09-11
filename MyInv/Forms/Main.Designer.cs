using System.Windows.Forms.PropertyGridInternal;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuPanel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuPanel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.Products = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Receipts = new System.Windows.Forms.TabPage();
            this.Invoices = new System.Windows.Forms.TabPage();
            this.Suppliers = new System.Windows.Forms.TabPage();
            this.Sales = new System.Windows.Forms.TabPage();
            this.Payments = new System.Windows.Forms.TabPage();
            this.Installments = new System.Windows.Forms.TabPage();
            this.Reminders = new System.Windows.Forms.TabPage();
            this.bunifuImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.bunifuLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox10 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.customMenu1 = new MyInv.customMenu();
            this.customCard1 = new MyInv.CustomCard();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.Products.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Reminders.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).BeginInit();
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
            this.bunifuPanel2.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel2.Controls.Add(this.guna2PictureBox10);
            this.bunifuPanel2.Controls.Add(this.customMenu1);
            this.bunifuPanel2.Controls.Add(this.bunifuPanel3);
            this.bunifuPanel2.Controls.Add(this.guna2Panel2);
            this.bunifuPanel2.Location = new System.Drawing.Point(2, 34);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.Size = new System.Drawing.Size(1195, 563);
            this.bunifuPanel2.TabIndex = 2;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderRadius = 10;
            this.bunifuPanel3.Controls.Add(this.guna2TabControl1);
            this.bunifuPanel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.bunifuPanel3.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bunifuPanel3.CustomizableEdges.BottomRight = false;
            this.bunifuPanel3.CustomizableEdges.TopRight = false;
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.bunifuPanel3.Location = new System.Drawing.Point(310, 36);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.bunifuPanel3.Size = new System.Drawing.Size(885, 527);
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
            this.guna2TabControl1.Location = new System.Drawing.Point(3, 3);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(882, 521);
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
            this.guna2TabControl1.TabMenuVisible = false;
            this.guna2TabControl1.TabStop = false;
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Products.Controls.Add(this.flowLayoutPanel1);
            this.Products.ForeColor = System.Drawing.Color.Beige;
            this.Products.Location = new System.Drawing.Point(5, 4);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(873, 513);
            this.Products.TabIndex = 0;
            this.Products.Text = "tabPage1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.customCard1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(867, 507);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
            // 
            // Receipts
            // 
            this.Receipts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Receipts.ForeColor = System.Drawing.Color.Beige;
            this.Receipts.Location = new System.Drawing.Point(184, 4);
            this.Receipts.Name = "Receipts";
            this.Receipts.Padding = new System.Windows.Forms.Padding(3);
            this.Receipts.Size = new System.Drawing.Size(694, 513);
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
            this.Invoices.Size = new System.Drawing.Size(694, 513);
            this.Invoices.TabIndex = 2;
            this.Invoices.Text = "tabPage3";
            // 
            // Suppliers
            // 
            this.Suppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Suppliers.ForeColor = System.Drawing.Color.Beige;
            this.Suppliers.Location = new System.Drawing.Point(184, 4);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(694, 513);
            this.Suppliers.TabIndex = 3;
            this.Suppliers.Text = "tabPage1";
            // 
            // Sales
            // 
            this.Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Sales.ForeColor = System.Drawing.Color.Beige;
            this.Sales.Location = new System.Drawing.Point(184, 4);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(694, 513);
            this.Sales.TabIndex = 4;
            this.Sales.Text = "tabPage1";
            // 
            // Payments
            // 
            this.Payments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Payments.ForeColor = System.Drawing.Color.Beige;
            this.Payments.Location = new System.Drawing.Point(184, 4);
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(694, 513);
            this.Payments.TabIndex = 5;
            this.Payments.Text = "tabPage1";
            // 
            // Installments
            // 
            this.Installments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Installments.ForeColor = System.Drawing.Color.Beige;
            this.Installments.Location = new System.Drawing.Point(184, 4);
            this.Installments.Name = "Installments";
            this.Installments.Size = new System.Drawing.Size(694, 513);
            this.Installments.TabIndex = 6;
            this.Installments.Text = "tabPage1";
            // 
            // Reminders
            // 
            this.Reminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Reminders.Controls.Add(this.bunifuImageButton1);
            this.Reminders.ForeColor = System.Drawing.Color.Beige;
            this.Reminders.Location = new System.Drawing.Point(184, 4);
            this.Reminders.Name = "Reminders";
            this.Reminders.Size = new System.Drawing.Size(694, 513);
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
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.guna2TileButton1);
            this.guna2Panel2.Controls.Add(this.btnAddProduct);
            this.guna2Panel2.Controls.Add(this.guna2ImageButton2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1195, 36);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 3;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(102)))), ((int)(((byte)(93)))));
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.4D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Size = new System.Drawing.Size(1196, 32);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseUp);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.BorderRadius = 3;
            this.guna2ControlBox1.CustomizableEdges.BottomLeft = false;
            this.guna2ControlBox1.CustomizableEdges.TopLeft = false;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(102)))), ((int)(((byte)(93)))));
            this.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(72)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1151, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderRadius = 3;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.CustomizableEdges.BottomLeft = false;
            this.guna2ControlBox2.CustomizableEdges.BottomRight = false;
            this.guna2ControlBox2.CustomizableEdges.TopLeft = false;
            this.guna2ControlBox2.CustomizableEdges.TopRight = false;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(102)))), ((int)(((byte)(93)))));
            this.guna2ControlBox2.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1107, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BorderRadius = 3;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.CustomizableEdges.BottomRight = false;
            this.guna2ControlBox3.CustomizableEdges.TopRight = false;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(102)))), ((int)(((byte)(93)))));
            this.guna2ControlBox3.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox3.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1063, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.PressedColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockForm = true;
            this.guna2DragControl1.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(102)))), ((int)(((byte)(93)))));
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.4D;
            this.guna2DragControl1.DragStartTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddProduct.HoverState.Image = global::MyInv.Properties.Resources.Add;
            this.btnAddProduct.HoverState.ImageOffset = new System.Drawing.Point(-1, -5);
            this.btnAddProduct.HoverState.ImageRotate = 45F;
            this.btnAddProduct.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddProduct.Image = global::MyInv.Properties.Resources.Add;
            this.btnAddProduct.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddProduct.ImageRotate = 0F;
            this.btnAddProduct.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddProduct.Location = new System.Drawing.Point(1129, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(33, 36);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.Location = new System.Drawing.Point(1162, 0);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.Size = new System.Drawing.Size(33, 36);
            this.guna2ImageButton2.TabIndex = 8;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.CustomImages.Image = global::MyInv.Properties.Resources.Add;
            this.guna2TileButton1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2TileButton1.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.guna2TileButton1.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2TileButton1.FillColor = System.Drawing.Color.Empty;
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.guna2TileButton1.Location = new System.Drawing.Point(1096, 0);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(33, 36);
            this.guna2TileButton1.TabIndex = 9;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuLabel1.BackgroundImage")));
            this.bunifuLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(85, 10);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(101, 45);
            this.bunifuLabel1.TabIndex = 5;
            this.bunifuLabel1.Text = null;
            // 
            // guna2PictureBox10
            // 
            this.guna2PictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox10.BorderRadius = 5;
            this.guna2PictureBox10.Image = global::MyInv.Properties.Resources.StocksTry;
            this.guna2PictureBox10.ImageRotate = 0F;
            this.guna2PictureBox10.Location = new System.Drawing.Point(6, 5);
            this.guna2PictureBox10.Name = "guna2PictureBox10";
            this.guna2PictureBox10.Size = new System.Drawing.Size(57, 56);
            this.guna2PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox10.TabIndex = 4;
            this.guna2PictureBox10.TabStop = false;
            // 
            // customMenu1
            // 
            this.customMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.customMenu1.Location = new System.Drawing.Point(0, 36);
            this.customMenu1.Name = "customMenu1";
            this.customMenu1.Size = new System.Drawing.Size(310, 527);
            this.customMenu1.TabIndex = 8;
            this.customMenu1.SelectedIndexChanged += new System.EventHandler(this.customMenu1_SelectedIndexChanged);
            // 
            // customCard1
            // 
            this.customCard1.AutoScroll = true;
            this.customCard1.BackColor = System.Drawing.Color.Transparent;
            this.customCard1.Cursor = System.Windows.Forms.Cursors.Default;
            this.customCard1.Location = new System.Drawing.Point(3, 3);
            this.customCard1.Name = "customCard1";
            this.customCard1.Size = new System.Drawing.Size(243, 346);
            this.customCard1.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(102)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyInv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseLeave += new System.EventHandler(this.Main_MouseLeave);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.Products.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Reminders.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel bunifuPanel2;
        private Guna.UI2.WinForms.Guna2Panel bunifuPanel3;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabPage Receipts;
        private System.Windows.Forms.TabPage Invoices;
        private System.Windows.Forms.TabPage Suppliers;
        private System.Windows.Forms.TabPage Sales;
        private System.Windows.Forms.TabPage Payments;
        private System.Windows.Forms.TabPage Installments;
        private System.Windows.Forms.TabPage Reminders;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton bunifuImageButton1;
        private CustomCard customCard1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private customMenu customMenu1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddProduct;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2HtmlLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox10;
    }
}

