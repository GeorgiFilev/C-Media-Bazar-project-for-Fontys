namespace ManagerAppMediaBazaar
{
    partial class AccountsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearchNoAcc = new System.Windows.Forms.TextBox();
            this.lbNoAcc = new System.Windows.Forms.ListBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCompanyEmail = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPassword2 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbPassword1 = new System.Windows.Forms.TextBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.panelBorderLeft = new System.Windows.Forms.Panel();
            this.lblAddUpdate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSearchAcc = new System.Windows.Forms.TextBox();
            this.lbAcc = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.revealPass = new FontAwesome.Sharp.IconPictureBox();
            this.errorProviderMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRole = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revealPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(361, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Account Management";
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
            this.btnHome.TabIndex = 39;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(21, 158);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 61);
            this.panel4.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Without Accounts";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.ForeColor = System.Drawing.Color.Snow;
            this.panel3.Location = new System.Drawing.Point(113, 143);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 1);
            this.panel3.TabIndex = 80;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSearch.Location = new System.Drawing.Point(6, 115);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 26);
            this.lblSearch.TabIndex = 79;
            this.lblSearch.Text = "Search";
            // 
            // tbSearchNoAcc
            // 
            this.tbSearchNoAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tbSearchNoAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchNoAcc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchNoAcc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbSearchNoAcc.Location = new System.Drawing.Point(113, 116);
            this.tbSearchNoAcc.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchNoAcc.Name = "tbSearchNoAcc";
            this.tbSearchNoAcc.Size = new System.Drawing.Size(144, 25);
            this.tbSearchNoAcc.TabIndex = 78;
            this.tbSearchNoAcc.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbNoAcc
            // 
            this.lbNoAcc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbNoAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNoAcc.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoAcc.FormattingEnabled = true;
            this.lbNoAcc.ItemHeight = 24;
            this.lbNoAcc.Location = new System.Drawing.Point(21, 218);
            this.lbNoAcc.Margin = new System.Windows.Forms.Padding(2);
            this.lbNoAcc.Name = "lbNoAcc";
            this.lbNoAcc.Size = new System.Drawing.Size(236, 240);
            this.lbNoAcc.TabIndex = 77;
            this.lbNoAcc.SelectedIndexChanged += new System.EventHandler(this.lbNoAcc_SelectedIndexChanged);
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfirmPass.Location = new System.Drawing.Point(603, 312);
            this.lblConfirmPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(176, 22);
            this.lblConfirmPass.TabIndex = 112;
            this.lblConfirmPass.Text = "Confirm Password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPassword.Location = new System.Drawing.Point(645, 259);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(133, 22);
            this.lblPassword.TabIndex = 111;
            this.lblPassword.Text = "Set Password:";
            // 
            // lblCompanyEmail
            // 
            this.lblCompanyEmail.AutoSize = true;
            this.lblCompanyEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyEmail.Location = new System.Drawing.Point(620, 197);
            this.lblCompanyEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyEmail.Name = "lblCompanyEmail";
            this.lblCompanyEmail.Size = new System.Drawing.Size(159, 22);
            this.lblCompanyEmail.TabIndex = 110;
            this.lblCompanyEmail.Text = "Company Email:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Location = new System.Drawing.Point(797, 220);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(184, 1);
            this.panel9.TabIndex = 106;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbEmail.Location = new System.Drawing.Point(797, 193);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(184, 24);
            this.tbEmail.TabIndex = 102;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(797, 339);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 1);
            this.panel2.TabIndex = 108;
            // 
            // tbPassword2
            // 
            this.tbPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tbPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword2.Location = new System.Drawing.Point(797, 312);
            this.tbPassword2.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.Size = new System.Drawing.Size(184, 24);
            this.tbPassword2.TabIndex = 104;
            this.tbPassword2.UseSystemPasswordChar = true;
            this.tbPassword2.TextChanged += new System.EventHandler(this.tbPassword2_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(797, 287);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 1);
            this.panel5.TabIndex = 109;
            // 
            // tbPassword1
            // 
            this.tbPassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tbPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword1.Location = new System.Drawing.Point(797, 259);
            this.tbPassword1.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword1.Name = "tbPassword1";
            this.tbPassword1.Size = new System.Drawing.Size(184, 24);
            this.tbPassword1.TabIndex = 105;
            this.tbPassword1.UseSystemPasswordChar = true;
            this.tbPassword1.TextChanged += new System.EventHandler(this.tbPassword1_TextChanged);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUpdate.Enabled = false;
            this.btnAddUpdate.FlatAppearance.BorderSize = 0;
            this.btnAddUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.btnAddUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddUpdate.Location = new System.Drawing.Point(699, 427);
            this.btnAddUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(215, 31);
            this.btnAddUpdate.TabIndex = 113;
            this.btnAddUpdate.Text = "Add / Update";
            this.btnAddUpdate.UseVisualStyleBackColor = false;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.ForeColor = System.Drawing.Color.Snow;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(797, 369);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(184, 33);
            this.cmbDepartment.TabIndex = 115;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            this.cmbDepartment.TextChanged += new System.EventHandler(this.cmbDepartment_TextChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRole.Location = new System.Drawing.Point(603, 374);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(180, 22);
            this.lblRole.TabIndex = 114;
            this.lblRole.Text = "Company Position:";
            // 
            // panelBorderLeft
            // 
            this.panelBorderLeft.BackColor = System.Drawing.Color.White;
            this.panelBorderLeft.Location = new System.Drawing.Point(290, 108);
            this.panelBorderLeft.Name = "panelBorderLeft";
            this.panelBorderLeft.Size = new System.Drawing.Size(1, 350);
            this.panelBorderLeft.TabIndex = 116;
            // 
            // lblAddUpdate
            // 
            this.lblAddUpdate.AutoSize = true;
            this.lblAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.lblAddUpdate.Location = new System.Drawing.Point(711, 87);
            this.lblAddUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddUpdate.Name = "lblAddUpdate";
            this.lblAddUpdate.Size = new System.Drawing.Size(241, 25);
            this.lblAddUpdate.TabIndex = 117;
            this.lblAddUpdate.Text = "Add / Update Account";
            this.lblAddUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(330, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 61);
            this.panel1.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Existing Accounts";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.ForeColor = System.Drawing.Color.Snow;
            this.panel6.Location = new System.Drawing.Point(423, 143);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(144, 1);
            this.panel6.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(316, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 84;
            this.label5.Text = "Search";
            // 
            // tbSearchAcc
            // 
            this.tbSearchAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tbSearchAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchAcc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchAcc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbSearchAcc.Location = new System.Drawing.Point(423, 116);
            this.tbSearchAcc.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchAcc.Name = "tbSearchAcc";
            this.tbSearchAcc.Size = new System.Drawing.Size(144, 25);
            this.tbSearchAcc.TabIndex = 83;
            this.tbSearchAcc.TextChanged += new System.EventHandler(this.tbSearchAcc_TextChanged);
            // 
            // lbAcc
            // 
            this.lbAcc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAcc.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcc.FormattingEnabled = true;
            this.lbAcc.ItemHeight = 24;
            this.lbAcc.Location = new System.Drawing.Point(330, 215);
            this.lbAcc.Margin = new System.Windows.Forms.Padding(2);
            this.lbAcc.Name = "lbAcc";
            this.lbAcc.Size = new System.Drawing.Size(237, 240);
            this.lbAcc.TabIndex = 82;
            this.lbAcc.SelectedIndexChanged += new System.EventHandler(this.lbAcc_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(597, 108);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 350);
            this.panel7.TabIndex = 117;
            // 
            // revealPass
            // 
            this.revealPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.revealPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.revealPass.IconColor = System.Drawing.Color.White;
            this.revealPass.IconSize = 35;
            this.revealPass.Location = new System.Drawing.Point(606, 253);
            this.revealPass.Margin = new System.Windows.Forms.Padding(2);
            this.revealPass.Name = "revealPass";
            this.revealPass.Size = new System.Drawing.Size(35, 35);
            this.revealPass.TabIndex = 118;
            this.revealPass.TabStop = false;
            this.revealPass.MouseLeave += new System.EventHandler(this.revealPass_MouseLeave);
            this.revealPass.MouseHover += new System.EventHandler(this.revealPass_MouseHover);
            // 
            // errorProviderMail
            // 
            this.errorProviderMail.ContainerControl = this;
            // 
            // errorProviderPassword1
            // 
            this.errorProviderPassword1.ContainerControl = this;
            // 
            // errorProviderRole
            // 
            this.errorProviderRole.ContainerControl = this;
            // 
            // errorProviderPassword2
            // 
            this.errorProviderPassword2.ContainerControl = this;
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.revealPass);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAddUpdate);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelBorderLeft);
            this.Controls.Add(this.tbSearchAcc);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lbAcc);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCompanyEmail);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbPassword2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tbPassword1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearchNoAcc);
            this.Controls.Add(this.lbNoAcc);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyGrowth";
            this.Load += new System.EventHandler(this.AccountsForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revealPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearchNoAcc;
        private System.Windows.Forms.ListBox lbNoAcc;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCompanyEmail;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPassword2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbPassword1;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panelBorderLeft;
        private System.Windows.Forms.Label lblAddUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSearchAcc;
        private System.Windows.Forms.ListBox lbAcc;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconPictureBox revealPass;
        private System.Windows.Forms.ErrorProvider errorProviderMail;
        private System.Windows.Forms.ErrorProvider errorProviderPassword1;
        private System.Windows.Forms.ErrorProvider errorProviderRole;
        private System.Windows.Forms.ErrorProvider errorProviderPassword2;
    }
}