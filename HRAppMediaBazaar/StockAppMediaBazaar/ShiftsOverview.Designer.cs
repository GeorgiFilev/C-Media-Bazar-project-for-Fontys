namespace StockAppMediaBazaar
{
    partial class ShiftsOverview
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
            this.lblOverview = new System.Windows.Forms.Label();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbShifts = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mtbWeek = new System.Windows.Forms.MaskedTextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblCurrentWeek = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDeleteError = new System.Windows.Forms.Label();
            this.lblUpdateError = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverview.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOverview.Location = new System.Drawing.Point(743, 22);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(350, 50);
            this.lblOverview.TabIndex = 79;
            this.lblOverview.Text = "Shifts Overview";
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.IconSize = 45;
            this.btnHome.Location = new System.Drawing.Point(2, 2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Rotation = 0D;
            this.btnHome.Size = new System.Drawing.Size(93, 71);
            this.btnHome.TabIndex = 80;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(75, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 81;
            this.label1.Text = "Select week";
            // 
            // lbShifts
            // 
            this.lbShifts.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShifts.FormattingEnabled = true;
            this.lbShifts.ItemHeight = 33;
            this.lbShifts.Location = new System.Drawing.Point(72, 434);
            this.lbShifts.Name = "lbShifts";
            this.lbShifts.Size = new System.Drawing.Size(912, 433);
            this.lbShifts.TabIndex = 83;
            this.lbShifts.SelectedIndexChanged += new System.EventHandler(this.LbShifts_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDate.Location = new System.Drawing.Point(1150, 614);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(151, 29);
            this.lblDate.TabIndex = 96;
            this.lblDate.Text = "Change day";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblShift.Location = new System.Drawing.Point(1150, 763);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(158, 29);
            this.lblShift.TabIndex = 95;
            this.lblShift.Text = "Change shift";
            // 
            // cmbShift
            // 
            this.cmbShift.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShift.ForeColor = System.Drawing.Color.Black;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(1449, 766);
            this.cmbShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(179, 29);
            this.cmbShift.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(1038, 364);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 630);
            this.panel1.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(1356, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 38);
            this.label2.TabIndex = 101;
            this.label2.Text = "Update shift";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(790, 897);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 59);
            this.button1.TabIndex = 102;
            this.button1.Text = "Delete shift";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mtbWeek
            // 
            this.mtbWeek.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbWeek.Location = new System.Drawing.Point(362, 267);
            this.mtbWeek.Mask = "00";
            this.mtbWeek.Name = "mtbWeek";
            this.mtbWeek.Size = new System.Drawing.Size(48, 31);
            this.mtbWeek.TabIndex = 104;
            this.mtbWeek.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtbWeek_MaskInputRejected);
            this.mtbWeek.TextChanged += new System.EventHandler(this.MtbWeek_TextChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.panel10.Controls.Add(this.lblCurrent);
            this.panel10.Location = new System.Drawing.Point(72, 364);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(912, 75);
            this.panel10.TabIndex = 120;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(256, 19);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(219, 34);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Current Shifts";
            // 
            // lblCurrentWeek
            // 
            this.lblCurrentWeek.AutoSize = true;
            this.lblCurrentWeek.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.lblCurrentWeek.Location = new System.Drawing.Point(1031, 207);
            this.lblCurrentWeek.Name = "lblCurrentWeek";
            this.lblCurrentWeek.Size = new System.Drawing.Size(143, 34);
            this.lblCurrentWeek.TabIndex = 122;
            this.lblCurrentWeek.Text = "_weekNr";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label69.Location = new System.Drawing.Point(684, 207);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(234, 34);
            this.label69.TabIndex = 121;
            this.label69.Text = "Current Week: ";
            // 
            // cmbDay
            // 
            this.cmbDay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDay.ForeColor = System.Drawing.Color.Black;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(1449, 614);
            this.cmbDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(179, 29);
            this.cmbDay.TabIndex = 123;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(1530, 874);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 62);
            this.btnUpdate.TabIndex = 124;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lblDeleteError
            // 
            this.lblDeleteError.AutoSize = true;
            this.lblDeleteError.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteError.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteError.Location = new System.Drawing.Point(254, 907);
            this.lblDeleteError.Name = "lblDeleteError";
            this.lblDeleteError.Size = new System.Drawing.Size(177, 32);
            this.lblDeleteError.TabIndex = 125;
            this.lblDeleteError.Text = "DeleteError";
            // 
            // lblUpdateError
            // 
            this.lblUpdateError.AutoSize = true;
            this.lblUpdateError.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateError.ForeColor = System.Drawing.Color.Red;
            this.lblUpdateError.Location = new System.Drawing.Point(1368, 479);
            this.lblUpdateError.Name = "lblUpdateError";
            this.lblUpdateError.Size = new System.Drawing.Size(188, 32);
            this.lblUpdateError.TabIndex = 126;
            this.lblUpdateError.Text = "UpdateError";
            // 
            // ShiftsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1800, 968);
            this.Controls.Add(this.lblUpdateError);
            this.Controls.Add(this.lblDeleteError);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.lblCurrentWeek);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.mtbWeek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.cmbShift);
            this.Controls.Add(this.lbShifts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblOverview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShiftsOverview";
            this.Text = "ShiftsOverview";
            this.Load += new System.EventHandler(this.ShiftsOverview_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOverview;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbShifts;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtbWeek;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblCurrentWeek;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDeleteError;
        private System.Windows.Forms.Label lblUpdateError;
    }
}