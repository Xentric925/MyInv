namespace MyInv
{
    partial class frmReminders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReminders));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.chkNotifyme = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.txtMemo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.numH = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumMin = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.chkAdvanceNotification = new System.Windows.Forms.CheckBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTime = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMin)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(34, 60);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(88, 20);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Choose Date:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(26, 167);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(91, 20);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "choose Time :";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // chkNotifyme
            // 
            this.chkNotifyme.AutoSize = true;
            this.chkNotifyme.Location = new System.Drawing.Point(397, 41);
            this.chkNotifyme.Name = "chkNotifyme";
            this.chkNotifyme.Size = new System.Drawing.Size(188, 20);
            this.chkNotifyme.TabIndex = 5;
            this.chkNotifyme.Text = "Notify me on thesame date";
            this.chkNotifyme.UseVisualStyleBackColor = true;
            this.chkNotifyme.CheckedChanged += new System.EventHandler(this.chkNotifyme_CheckedChanged);
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(601, 41);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(167, 20);
            this.chkEmail.TabIndex = 6;
            this.chkEmail.Text = "Notify Client/sendEmail";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // txtMemo
            // 
            this.txtMemo.AcceptsReturn = false;
            this.txtMemo.AcceptsTab = false;
            this.txtMemo.AnimationSpeed = 200;
            this.txtMemo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMemo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMemo.AutoSizeHeight = true;
            this.txtMemo.BackColor = System.Drawing.Color.Transparent;
            this.txtMemo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMemo.BackgroundImage")));
            this.txtMemo.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtMemo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMemo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMemo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMemo.BorderRadius = 1;
            this.txtMemo.BorderThickness = 1;
            this.txtMemo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMemo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemo.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtMemo.DefaultText = "";
            this.txtMemo.FillColor = System.Drawing.Color.White;
            this.txtMemo.HideSelection = true;
            this.txtMemo.IconLeft = null;
            this.txtMemo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemo.IconPadding = 10;
            this.txtMemo.IconRight = null;
            this.txtMemo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemo.Lines = new string[0];
            this.txtMemo.Location = new System.Drawing.Point(381, 223);
            this.txtMemo.MaxLength = 32767;
            this.txtMemo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMemo.Modified = false;
            this.txtMemo.Multiline = false;
            this.txtMemo.Name = "txtMemo";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMemo.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMemo.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMemo.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMemo.OnIdleState = stateProperties4;
            this.txtMemo.Padding = new System.Windows.Forms.Padding(3);
            this.txtMemo.PasswordChar = '\0';
            this.txtMemo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMemo.PlaceholderText = "Enter text";
            this.txtMemo.ReadOnly = false;
            this.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemo.SelectedText = "";
            this.txtMemo.SelectionLength = 0;
            this.txtMemo.SelectionStart = 0;
            this.txtMemo.ShortcutsEnabled = true;
            this.txtMemo.Size = new System.Drawing.Size(387, 175);
            this.txtMemo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtMemo.TabIndex = 7;
            this.txtMemo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMemo.TextMarginBottom = 0;
            this.txtMemo.TextMarginLeft = 3;
            this.txtMemo.TextMarginTop = 1;
            this.txtMemo.TextPlaceholder = "Enter text";
            this.txtMemo.UseSystemPasswordChar = false;
            this.txtMemo.WordWrap = true;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.Location = new System.Drawing.Point(430, 148);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(121, 20);
            this.bunifuLabel3.TabIndex = 8;
            this.bunifuLabel3.Text = "Enter your memo :";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // numH
            // 
            this.numH.BackColor = System.Drawing.Color.Transparent;
            this.numH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numH.Location = new System.Drawing.Point(34, 223);
            this.numH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numH.Name = "numH";
            this.numH.Size = new System.Drawing.Size(56, 29);
            this.numH.TabIndex = 10;
            this.numH.ValueChanged += new System.EventHandler(this.numH_ValueChanged_1);
            // 
            // NumMin
            // 
            this.NumMin.BackColor = System.Drawing.Color.Transparent;
            this.NumMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumMin.Location = new System.Drawing.Point(147, 223);
            this.NumMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumMin.Name = "NumMin";
            this.NumMin.Size = new System.Drawing.Size(56, 29);
            this.NumMin.TabIndex = 11;
            this.NumMin.ValueChanged += new System.EventHandler(this.NumMin_ValueChanged_1);
            // 
            // chkAdvanceNotification
            // 
            this.chkAdvanceNotification.AutoSize = true;
            this.chkAdvanceNotification.Location = new System.Drawing.Point(397, 92);
            this.chkAdvanceNotification.Name = "chkAdvanceNotification";
            this.chkAdvanceNotification.Size = new System.Drawing.Size(88, 20);
            this.chkAdvanceNotification.TabIndex = 12;
            this.chkAdvanceNotification.Text = "Notify me ";
            this.chkAdvanceNotification.UseVisualStyleBackColor = true;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.Location = new System.Drawing.Point(102, 232);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(11, 20);
            this.bunifuLabel4.TabIndex = 13;
            this.bunifuLabel4.Text = "H";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel5.Location = new System.Drawing.Point(239, 232);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(25, 20);
            this.bunifuLabel5.TabIndex = 14;
            this.bunifuLabel5.Text = "Min";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtPicker
            // 
            this.dtPicker.Checked = true;
            this.dtPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPicker.Location = new System.Drawing.Point(26, 86);
            this.dtPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 50);
            this.dtPicker.TabIndex = 16;
            this.dtPicker.Value = new System.DateTime(2023, 8, 26, 13, 22, 43, 374);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(34, 369);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton1.TabIndex = 19;
            this.guna2GradientButton1.Text = "guna2GradientButton1";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(34, 285);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(169, 42);
            this.txtTime.TabIndex = 20;
            this.txtTime.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "days in advance";
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDays.Location = new System.Drawing.Point(478, 90);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(40, 24);
            this.cmbDays.TabIndex = 23;
            // 
            // frmReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.chkAdvanceNotification);
            this.Controls.Add(this.NumMin);
            this.Controls.Add(this.numH);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.chkEmail);
            this.Controls.Add(this.chkNotifyme);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Name = "frmReminders";
            this.Text = "frmReminders";
            this.Load += new System.EventHandler(this.frmReminders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.CheckBox chkNotifyme;
        private System.Windows.Forms.CheckBox chkEmail;
        private Bunifu.UI.WinForms.BunifuTextBox txtMemo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Guna.UI2.WinForms.Guna2NumericUpDown numH;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumMin;
        private System.Windows.Forms.CheckBox chkAdvanceNotification;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPicker;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.RichTextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDays;
    }
}