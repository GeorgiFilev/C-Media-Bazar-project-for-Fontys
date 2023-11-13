namespace SalesAppMediaBazaar
{
    partial class SalesForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.iconBtnClose = new FontAwesome.Sharp.IconButton();
            this.lstbSales = new System.Windows.Forms.ListBox();
            this.txtbStock = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewTypes = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconBtnClose
            // 
            this.iconBtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnClose.FlatAppearance.BorderSize = 0;
            this.iconBtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.iconBtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.iconBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnClose.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconBtnClose.IconColor = System.Drawing.Color.White;
            this.iconBtnClose.IconSize = 30;
            this.iconBtnClose.Location = new System.Drawing.Point(9, 28);
            this.iconBtnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconBtnClose.Name = "iconBtnClose";
            this.iconBtnClose.Rotation = 0D;
            this.iconBtnClose.Size = new System.Drawing.Size(71, 62);
            this.iconBtnClose.TabIndex = 0;
            this.iconBtnClose.UseVisualStyleBackColor = true;
            this.iconBtnClose.Click += new System.EventHandler(this.iconBtnClose_Click);
            // 
            // lstbSales
            // 
            this.lstbSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lstbSales.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstbSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstbSales.ForeColor = System.Drawing.Color.White;
            this.lstbSales.FormattingEnabled = true;
            this.lstbSales.ItemHeight = 22;
            this.lstbSales.Location = new System.Drawing.Point(0, 0);
            this.lstbSales.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstbSales.Name = "lstbSales";
            this.lstbSales.Size = new System.Drawing.Size(488, 501);
            this.lstbSales.TabIndex = 1;
            // 
            // txtbStock
            // 
            this.txtbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbStock.Location = new System.Drawing.Point(611, 94);
            this.txtbStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbStock.Multiline = true;
            this.txtbStock.Name = "txtbStock";
            this.txtbStock.Size = new System.Drawing.Size(136, 50);
            this.txtbStock.TabIndex = 5;
            this.txtbStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(604, 58);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(141, 32);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Quantity :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.flowLayoutPanel1.Controls.Add(this.listViewTypes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1028, 81);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // listViewTypes
            // 
            this.listViewTypes.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.listViewTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewTypes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listViewTypes.HideSelection = false;
            this.listViewTypes.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.listViewTypes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewTypes.Location = new System.Drawing.Point(0, 2);
            this.listViewTypes.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.listViewTypes.MultiSelect = false;
            this.listViewTypes.Name = "listViewTypes";
            this.listViewTypes.Size = new System.Drawing.Size(1062, 78);
            this.listViewTypes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTypes.TabIndex = 11;
            this.listViewTypes.UseCompatibleStateImageBehavior = false;
            this.listViewTypes.View = System.Windows.Forms.View.SmallIcon;
            this.listViewTypes.SelectedIndexChanged += new System.EventHandler(this.listViewTypes_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconBtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 501);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.btnSendRequest);
            this.panel2.Controls.Add(this.lstbSales);
            this.panel2.Controls.Add(this.txtbStock);
            this.panel2.Controls.Add(this.lblAmount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(199, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 501);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendRequest.FlatAppearance.BorderSize = 0;
            this.btnSendRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.btnSendRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnSendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendRequest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRequest.Location = new System.Drawing.Point(632, 307);
            this.btnSendRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(105, 72);
            this.btnSendRequest.TabIndex = 7;
            this.btnSendRequest.Text = "Send request";
            this.btnSendRequest.UseVisualStyleBackColor = false;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1028, 582);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBtnClose;
        private System.Windows.Forms.ListBox lstbSales;
        private System.Windows.Forms.TextBox txtbStock;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.ListView listViewTypes;
    }
}