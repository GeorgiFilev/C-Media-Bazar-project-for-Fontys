namespace ManagerAppMediaBazaar
{
    partial class ContractsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbContracts = new System.Windows.Forms.ListBox();
            this.btnConfirmFire = new System.Windows.Forms.Button();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEmployment = new System.Windows.Forms.ListBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDeny = new System.Windows.Forms.Button();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.btnDenyTermination = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(104, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Contract Termination Requests";
            // 
            // lbContracts
            // 
            this.lbContracts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContracts.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbContracts.FormattingEnabled = true;
            this.lbContracts.ItemHeight = 22;
            this.lbContracts.Location = new System.Drawing.Point(41, 85);
            this.lbContracts.Margin = new System.Windows.Forms.Padding(2);
            this.lbContracts.Name = "lbContracts";
            this.lbContracts.Size = new System.Drawing.Size(447, 158);
            this.lbContracts.TabIndex = 25;
            this.lbContracts.SelectedIndexChanged += new System.EventHandler(this.lbContracts_SelectedIndexChanged);
            // 
            // btnConfirmFire
            // 
            this.btnConfirmFire.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmFire.FlatAppearance.BorderSize = 0;
            this.btnConfirmFire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.btnConfirmFire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnConfirmFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmFire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmFire.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmFire.Location = new System.Drawing.Point(41, 458);
            this.btnConfirmFire.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmFire.Name = "btnConfirmFire";
            this.btnConfirmFire.Size = new System.Drawing.Size(219, 31);
            this.btnConfirmFire.TabIndex = 24;
            this.btnConfirmFire.Text = "Terminate Contract";
            this.btnConfirmFire.UseVisualStyleBackColor = false;
            this.btnConfirmFire.Click += new System.EventHandler(this.btnConfirmFire_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHome.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconSize = 40;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnHome.Rotation = 0D;
            this.btnHome.Size = new System.Drawing.Size(86, 71);
            this.btnHome.TabIndex = 28;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(612, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Employment requests";
            // 
            // lbEmployment
            // 
            this.lbEmployment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbEmployment.FormattingEnabled = true;
            this.lbEmployment.ItemHeight = 22;
            this.lbEmployment.Location = new System.Drawing.Point(616, 98);
            this.lbEmployment.Margin = new System.Windows.Forms.Padding(2);
            this.lbEmployment.Name = "lbEmployment";
            this.lbEmployment.Size = new System.Drawing.Size(325, 334);
            this.lbEmployment.TabIndex = 34;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.btnApprove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApprove.Location = new System.Drawing.Point(616, 458);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(110, 31);
            this.btnApprove.TabIndex = 35;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(536, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 400);
            this.panel7.TabIndex = 38;
            // 
            // btnDeny
            // 
            this.btnDeny.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeny.FlatAppearance.BorderSize = 0;
            this.btnDeny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.btnDeny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnDeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeny.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeny.Location = new System.Drawing.Point(832, 458);
            this.btnDeny.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(123, 31);
            this.btnDeny.TabIndex = 40;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = false;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // tbReason
            // 
            this.tbReason.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReason.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbReason.Location = new System.Drawing.Point(41, 298);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.ReadOnly = true;
            this.tbReason.Size = new System.Drawing.Size(447, 149);
            this.tbReason.TabIndex = 41;
            // 
            // btnDenyTermination
            // 
            this.btnDenyTermination.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDenyTermination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDenyTermination.FlatAppearance.BorderSize = 0;
            this.btnDenyTermination.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.btnDenyTermination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnDenyTermination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenyTermination.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenyTermination.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDenyTermination.Location = new System.Drawing.Point(365, 458);
            this.btnDenyTermination.Margin = new System.Windows.Forms.Padding(2);
            this.btnDenyTermination.Name = "btnDenyTermination";
            this.btnDenyTermination.Size = new System.Drawing.Size(123, 31);
            this.btnDenyTermination.TabIndex = 42;
            this.btnDenyTermination.Text = "Deny";
            this.btnDenyTermination.UseVisualStyleBackColor = false;
            this.btnDenyTermination.Click += new System.EventHandler(this.btnDenyTermination_Click);
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btnDenyTermination);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lbEmployment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbContracts);
            this.Controls.Add(this.btnConfirmFire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContractsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contracts";
            this.Load += new System.EventHandler(this.Contracts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbContracts;
        private System.Windows.Forms.Button btnConfirmFire;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbEmployment;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.Button btnDenyTermination;
    }
}