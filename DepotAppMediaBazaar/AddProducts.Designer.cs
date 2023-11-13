namespace DepotAppMediaBazaar
{
    partial class AddProducts
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbAddedProducts = new System.Windows.Forms.ListBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnAddToCurrentStock = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDetails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbType = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbQuantity2 = new System.Windows.Forms.Label();
            this.lbShowType = new System.Windows.Forms.Label();
            this.lbShowName = new System.Windows.Forms.Label();
            this.lbShowModel = new System.Windows.Forms.Label();
            this.lbShowQuantity = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.cmbDepartments = new System.Windows.Forms.ComboBox();
            this.lbDepartment2 = new System.Windows.Forms.Label();
            this.lbShowDepartment = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderQuantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDepartment = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbWarning2 = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(207, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(83, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(213, 185);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(209, 37);
            this.tbName.TabIndex = 2;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.TbName_Validating);
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(213, 244);
            this.tbModel.Margin = new System.Windows.Forms.Padding(4);
            this.tbModel.Multiline = true;
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(209, 37);
            this.tbModel.TabIndex = 3;
            this.tbModel.Validating += new System.ComponentModel.CancelEventHandler(this.TbModel_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(80, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(204, 505);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbAddedProducts
            // 
            this.lbAddedProducts.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddedProducts.FormattingEnabled = true;
            this.lbAddedProducts.ItemHeight = 21;
            this.lbAddedProducts.Location = new System.Drawing.Point(633, 133);
            this.lbAddedProducts.Margin = new System.Windows.Forms.Padding(4);
            this.lbAddedProducts.Name = "lbAddedProducts";
            this.lbAddedProducts.Size = new System.Drawing.Size(381, 298);
            this.lbAddedProducts.TabIndex = 6;
            this.lbAddedProducts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbQuantity.Location = new System.Drawing.Point(53, 305);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(117, 28);
            this.lbQuantity.TabIndex = 10;
            this.lbQuantity.Text = "Quantity:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Location = new System.Drawing.Point(213, 300);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuantity.Multiline = true;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(209, 37);
            this.tbQuantity.TabIndex = 11;
            this.tbQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.TbQuantity_Validating);
            // 
            // btnAddToCurrentStock
            // 
            this.btnAddToCurrentStock.BackColor = System.Drawing.Color.White;
            this.btnAddToCurrentStock.FlatAppearance.BorderSize = 0;
            this.btnAddToCurrentStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.btnAddToCurrentStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnAddToCurrentStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCurrentStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCurrentStock.Location = new System.Drawing.Point(611, 505);
            this.btnAddToCurrentStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToCurrentStock.Name = "btnAddToCurrentStock";
            this.btnAddToCurrentStock.Size = new System.Drawing.Size(368, 44);
            this.btnAddToCurrentStock.TabIndex = 12;
            this.btnAddToCurrentStock.Text = "Move to current stock";
            this.btnAddToCurrentStock.UseVisualStyleBackColor = false;
            this.btnAddToCurrentStock.Click += new System.EventHandler(this.btnAddToCurrentStock_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(213, 138);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(212, 29);
            this.cmbType.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(93, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Type:";
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.lbDetails.Location = new System.Drawing.Point(1206, 71);
            this.lbDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(113, 34);
            this.lbDetails.TabIndex = 15;
            this.lbDetails.Text = "Details:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(504, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 492);
            this.panel1.TabIndex = 16;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbType.Location = new System.Drawing.Point(1171, 180);
            this.lbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(65, 23);
            this.lbType.TabIndex = 17;
            this.lbType.Text = "Type:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbName.Location = new System.Drawing.Point(1171, 245);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(73, 23);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Name:";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbModel.Location = new System.Drawing.Point(1169, 308);
            this.lbModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(75, 23);
            this.lbModel.TabIndex = 19;
            this.lbModel.Text = "Model:";
            // 
            // lbQuantity2
            // 
            this.lbQuantity2.AutoSize = true;
            this.lbQuantity2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbQuantity2.Location = new System.Drawing.Point(1169, 364);
            this.lbQuantity2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuantity2.Name = "lbQuantity2";
            this.lbQuantity2.Size = new System.Drawing.Size(98, 23);
            this.lbQuantity2.TabIndex = 20;
            this.lbQuantity2.Text = "Quantity:";
            // 
            // lbShowType
            // 
            this.lbShowType.AutoSize = true;
            this.lbShowType.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowType.ForeColor = System.Drawing.Color.White;
            this.lbShowType.Location = new System.Drawing.Point(1267, 180);
            this.lbShowType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShowType.Name = "lbShowType";
            this.lbShowType.Size = new System.Drawing.Size(0, 22);
            this.lbShowType.TabIndex = 21;
            // 
            // lbShowName
            // 
            this.lbShowName.AutoSize = true;
            this.lbShowName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowName.ForeColor = System.Drawing.Color.White;
            this.lbShowName.Location = new System.Drawing.Point(1267, 245);
            this.lbShowName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShowName.Name = "lbShowName";
            this.lbShowName.Size = new System.Drawing.Size(0, 22);
            this.lbShowName.TabIndex = 22;
            // 
            // lbShowModel
            // 
            this.lbShowModel.AutoSize = true;
            this.lbShowModel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowModel.ForeColor = System.Drawing.Color.White;
            this.lbShowModel.Location = new System.Drawing.Point(1267, 306);
            this.lbShowModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShowModel.Name = "lbShowModel";
            this.lbShowModel.Size = new System.Drawing.Size(0, 22);
            this.lbShowModel.TabIndex = 23;
            // 
            // lbShowQuantity
            // 
            this.lbShowQuantity.AutoSize = true;
            this.lbShowQuantity.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowQuantity.ForeColor = System.Drawing.Color.White;
            this.lbShowQuantity.Location = new System.Drawing.Point(1291, 365);
            this.lbShowQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShowQuantity.Name = "lbShowQuantity";
            this.lbShowQuantity.Size = new System.Drawing.Size(0, 22);
            this.lbShowQuantity.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1135, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 492);
            this.panel2.TabIndex = 17;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.panel10.Controls.Add(this.label6);
            this.panel10.Location = new System.Drawing.Point(633, 71);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(381, 56);
            this.panel10.TabIndex = 121;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Staging Area";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDepartment.Location = new System.Drawing.Point(2, 361);
            this.lbDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(157, 28);
            this.lbDepartment.TabIndex = 122;
            this.lbDepartment.Text = "Department:";
            // 
            // cmbDepartments
            // 
            this.cmbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartments.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.cmbDepartments.FormattingEnabled = true;
            this.cmbDepartments.Location = new System.Drawing.Point(213, 359);
            this.cmbDepartments.Name = "cmbDepartments";
            this.cmbDepartments.Size = new System.Drawing.Size(209, 29);
            this.cmbDepartments.TabIndex = 123;
            // 
            // lbDepartment2
            // 
            this.lbDepartment2.AutoSize = true;
            this.lbDepartment2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDepartment2.Location = new System.Drawing.Point(1169, 420);
            this.lbDepartment2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDepartment2.Name = "lbDepartment2";
            this.lbDepartment2.Size = new System.Drawing.Size(133, 23);
            this.lbDepartment2.TabIndex = 124;
            this.lbDepartment2.Text = "Department:";
            // 
            // lbShowDepartment
            // 
            this.lbShowDepartment.AutoSize = true;
            this.lbShowDepartment.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.lbShowDepartment.ForeColor = System.Drawing.Color.White;
            this.lbShowDepartment.Location = new System.Drawing.Point(1343, 420);
            this.lbShowDepartment.Name = "lbShowDepartment";
            this.lbShowDepartment.Size = new System.Drawing.Size(0, 22);
            this.lbShowDepartment.TabIndex = 125;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderModel
            // 
            this.errorProviderModel.ContainerControl = this;
            // 
            // errorProviderQuantity
            // 
            this.errorProviderQuantity.ContainerControl = this;
            // 
            // errorProviderDepartment
            // 
            this.errorProviderDepartment.ContainerControl = this;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(81, 422);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 22);
            this.lbWarning.TabIndex = 126;
            // 
            // lbWarning2
            // 
            this.lbWarning2.AutoSize = true;
            this.lbWarning2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.lbWarning2.ForeColor = System.Drawing.Color.Red;
            this.lbWarning2.Location = new System.Drawing.Point(634, 462);
            this.lbWarning2.Name = "lbWarning2";
            this.lbWarning2.Size = new System.Drawing.Size(0, 22);
            this.lbWarning2.TabIndex = 127;
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1365, 624);
            this.Controls.Add(this.lbWarning2);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.lbShowDepartment);
            this.Controls.Add(this.lbDepartment2);
            this.Controls.Add(this.cmbDepartments);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbShowQuantity);
            this.Controls.Add(this.lbShowModel);
            this.Controls.Add(this.lbShowName);
            this.Controls.Add(this.lbShowType);
            this.Controls.Add(this.lbQuantity2);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnAddToCurrentStock);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbAddedProducts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbAddedProducts;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnAddToCurrentStock;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbQuantity2;
        private System.Windows.Forms.Label lbShowType;
        private System.Windows.Forms.Label lbShowName;
        private System.Windows.Forms.Label lbShowModel;
        private System.Windows.Forms.Label lbShowQuantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.ComboBox cmbDepartments;
        private System.Windows.Forms.Label lbDepartment2;
        private System.Windows.Forms.Label lbShowDepartment;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderModel;
        private System.Windows.Forms.ErrorProvider errorProviderQuantity;
        private System.Windows.Forms.ErrorProvider errorProviderDepartment;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbWarning2;
    }
}