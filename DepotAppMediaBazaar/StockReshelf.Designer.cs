namespace DepotAppMediaBazaar
{
    partial class StockReshelf
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
            this.lbReshelfRequests = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendStock = new System.Windows.Forms.Button();
            this.lbWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbReshelfRequests
            // 
            this.lbReshelfRequests.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReshelfRequests.FormattingEnabled = true;
            this.lbReshelfRequests.ItemHeight = 23;
            this.lbReshelfRequests.Location = new System.Drawing.Point(195, 140);
            this.lbReshelfRequests.Margin = new System.Windows.Forms.Padding(4);
            this.lbReshelfRequests.Name = "lbReshelfRequests";
            this.lbReshelfRequests.Size = new System.Drawing.Size(491, 280);
            this.lbReshelfRequests.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(289, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock reshelf requests:";
            // 
            // btnSendStock
            // 
            this.btnSendStock.BackColor = System.Drawing.Color.White;
            this.btnSendStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.btnSendStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnSendStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendStock.Location = new System.Drawing.Point(334, 532);
            this.btnSendStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendStock.Name = "btnSendStock";
            this.btnSendStock.Size = new System.Drawing.Size(216, 55);
            this.btnSendStock.TabIndex = 2;
            this.btnSendStock.Text = "Reshelf";
            this.btnSendStock.UseVisualStyleBackColor = false;
            this.btnSendStock.Click += new System.EventHandler(this.btnSendStock_Click);
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(291, 468);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 22);
            this.lbWarning.TabIndex = 131;
            // 
            // StockReshelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1365, 624);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.btnSendStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbReshelfRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockReshelf";
            this.Text = "StockReshelf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbReshelfRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendStock;
        private System.Windows.Forms.Label lbWarning;
    }
}