namespace StockAppMediaBazaar
{
    partial class Contracts
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
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnTermRequest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.lbTermRequest = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.IconSize = 45;
            this.btnHome.Location = new System.Drawing.Point(0, -1);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Rotation = 0D;
            this.btnHome.Size = new System.Drawing.Size(93, 71);
            this.btnHome.TabIndex = 28;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnTermRequest
            // 
            this.btnTermRequest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTermRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTermRequest.FlatAppearance.BorderSize = 0;
            this.btnTermRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnTermRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTermRequest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermRequest.ForeColor = System.Drawing.Color.Black;
            this.btnTermRequest.Location = new System.Drawing.Point(129, 797);
            this.btnTermRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTermRequest.Name = "btnTermRequest";
            this.btnTermRequest.Size = new System.Drawing.Size(489, 65);
            this.btnTermRequest.TabIndex = 40;
            this.btnTermRequest.Text = "Request Termination";
            this.btnTermRequest.UseVisualStyleBackColor = false;
            this.btnTermRequest.Click += new System.EventHandler(this.BtnTermRequest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(484, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 38);
            this.label3.TabIndex = 42;
            this.label3.Text = "Contract Termination";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSearch.Location = new System.Drawing.Point(61, 185);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(114, 32);
            this.lblSearch.TabIndex = 75;
            this.lblSearch.Text = "Search";
            // 
            // tbRequest
            // 
            this.tbRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.tbRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRequest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbRequest.Location = new System.Drawing.Point(263, 190);
            this.tbRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(157, 32);
            this.tbRequest.TabIndex = 74;
            this.tbRequest.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lbTermRequest
            // 
            this.lbTermRequest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTermRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTermRequest.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTermRequest.FormattingEnabled = true;
            this.lbTermRequest.ItemHeight = 33;
            this.lbTermRequest.Location = new System.Drawing.Point(129, 422);
            this.lbTermRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTermRequest.Name = "lbTermRequest";
            this.lbTermRequest.Size = new System.Drawing.Size(460, 330);
            this.lbTermRequest.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(1048, 301);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 601);
            this.panel1.TabIndex = 76;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(263, 223);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 1);
            this.panel2.TabIndex = 77;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(129, 332);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 91);
            this.panel4.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Termination Requests";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1371, 332);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 91);
            this.panel3.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reason For Termination";
            // 
            // tbReason
            // 
            this.tbReason.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReason.Location = new System.Drawing.Point(1371, 422);
            this.tbReason.Margin = new System.Windows.Forms.Padding(4);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(480, 351);
            this.tbReason.TabIndex = 80;
            this.tbReason.TextChanged += new System.EventHandler(this.TbReason_TextChanged);
            // 
            // Contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.lbTermRequest);
            this.Controls.Add(this.btnTermRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(981, 471);
            this.Name = "Contracts";
            this.Text = "Contracts";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Button btnTermRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.ListBox lbTermRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReason;
    }
}